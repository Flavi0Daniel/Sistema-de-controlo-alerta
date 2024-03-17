using SistemaControloAlerta.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControloAlerta._Repositories
{
    public class DepaRepository : BaseRepository, IDepaRepository
    {

        // Constructor
        public DepaRepository(string connectionString) {
            this.connectionString = connectionString;
        }

        // Methods
        public void Add(DepaModel depa)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                string query = "INSERT INTO tbl_Depart_Est_Plan_Anal values(@assunto, @conteudo, @area, @noi, @data, @prazo, @obs)";
                connection.Open();
                command.CommandText = query;
                command.Parameters.Add("@assunto", SqlDbType.NVarChar).Value = depa.Assunto;
                command.Parameters.Add("@conteudo", SqlDbType.NVarChar).Value = depa.Conteudo_despacho;
                command.Parameters.Add("@area", SqlDbType.NVarChar).Value = depa.Area_afectada;
                command.Parameters.Add("@noi", SqlDbType.NVarChar).Value = depa.Numero_de_oficio;
                command.Parameters.Add("@data", SqlDbType.DateTime).Value = depa.Data_orientacao;
                command.Parameters.Add("@prazo", SqlDbType.DateTime).Value = depa.Prazo;
                command.Parameters.Add("@obs", SqlDbType.NVarChar).Value = depa.Obs;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                string query = "DELETE FROM tbl_Depart_Est_Plan_Anal WHERE Num=@id";
                connection.Open();
                command.CommandText = query;
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(DepaModel depa)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                string query = "UPDATE tbl_Depart_Est_Plan_Anal SET Assunto=@assunto, conteudo_Despacho=@conteudo, Area_Afectada=@area, Numero_de_oficio=@noi, Data_Orientacao=@data, Prazo=@prazo, Obs=@obs WHERE Num=@id";
                connection.Open();
                command.CommandText = query;
                command.Parameters.Add("@assunto", SqlDbType.NVarChar).Value = depa.Assunto;
                command.Parameters.Add("@conteudo", SqlDbType.NVarChar).Value = depa.Conteudo_despacho;
                command.Parameters.Add("@area", SqlDbType.NVarChar).Value = depa.Area_afectada;
                command.Parameters.Add("@noi", SqlDbType.NVarChar).Value = depa.Numero_de_oficio;
                command.Parameters.Add("@data", SqlDbType.DateTime).Value = depa.Data_orientacao;
                command.Parameters.Add("@prazo", SqlDbType.DateTime).Value = depa.Prazo;
                command.Parameters.Add("@obs", SqlDbType.NVarChar).Value = depa.Obs;
                command.Parameters.Add("@id", SqlDbType.Int).Value = depa.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<DepaModel> GetAll()
        {
            var depaList = new List<DepaModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand()) {
                string query = @"SELECT Num, Assunto, conteudo_Despacho, Area_Afectada, Numero_de_oficio, Data_Orientacao, Prazo, Obs,
                        CASE
                            WHEN CONVERT(DATE, GETDATE()) > CONVERT(DATE, Prazo) THEN 'VENCEU'
                            WHEN CONVERT(DATE, GETDATE()) = CONVERT(DATE, Prazo) THEN 'VENCEU HOJE'
                            ELSE (CAST(DATEDIFF(DAY, CONVERT(DATE, GETDATE()), CONVERT(DATE, Prazo)) AS NVARCHAR) + ' DIAS PARA VENCER') 
                        END AS Alerta,
                        CASE
                            WHEN Obs = 'CUMPRIDA' THEN 'CUMPRIDA'
                            WHEN Obs = 'NÃO CUMPRIDA' THEN 'NÃO CUMPRIDA'
                            ELSE ''
                        END AS [Grau de comprimento]
                    FROM
                        tbl_Depart_Est_Plan_Anal ORDER BY Num DESC";
                connection.Open();
                command.CommandText = query;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var depaModel = new DepaModel();
                        depaModel.Id = (int)reader[0];
                        depaModel.Assunto = reader[1].ToString();
                        depaModel.Conteudo_despacho = reader[2].ToString();
                        depaModel.Area_afectada = reader[3].ToString();
                        depaModel.Numero_de_oficio = reader[4].ToString();
                        depaModel.Data_orientacao = DateTime.Parse(reader[5].ToString());
                        depaModel.Prazo = DateTime.Parse(reader[6].ToString());
                        depaModel.Obs = reader[7].ToString();
                        depaModel.Alerta = reader[8].ToString();
                        depaModel.GrauCumprimento = reader[9].ToString();
                        depaList.Add(depaModel);
                    }
                }
            }
            return depaList;
        }

        public IEnumerable<DepaModel> GetAllNotifications()
        {
            var depaList = new List<DepaModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                string query = @"CREATE OR ALTER VIEW notifications AS
                SELECT Num, Prazo,
                        CASE
                            WHEN CONVERT(DATE, GETDATE()) > CONVERT(DATE, Prazo) THEN 'VENCEU'
                            WHEN CONVERT(DATE, GETDATE()) = CONVERT(DATE, Prazo) THEN 'VENCEU HOJE'
                            ELSE (CAST(DATEDIFF(DAY, CONVERT(DATE, GETDATE()), CONVERT(DATE, Prazo)) AS NVARCHAR) + ' DIAS PARA VENCER') 
                        END AS Alerta,
                        CASE
                            WHEN Obs = 'CUMPRIDA' THEN 'CUMPRIDA'
                            WHEN Obs = 'NÃO CUMPRIDA' THEN 'NÃO CUMPRIDA'
                            ELSE ''
                        END AS [Grau de comprimento]
                    FROM
                        tbl_Depart_Est_Plan_Anal";
                connection.Open();
                command.CommandText = query;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var depaModel = new DepaModel();
                        depaModel.Id = (int)reader[0];
                        depaModel.Assunto = reader[1].ToString();
                        depaModel.Prazo = DateTime.Parse(reader[2].ToString());
                        depaModel.Alerta = reader[3].ToString();
                        depaModel.GrauCumprimento = reader[4].ToString();
                        depaList.Add(depaModel);
                    }
                }
            }
            return depaList;
        }

        public IEnumerable<DepaModel> GetByValue(string value)
        {
            var depaList = new List<DepaModel>();
            int depaId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string conteudoDespacho = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                string query = @"SELECT Num, Assunto, conteudo_Despacho, Area_Afectada, Numero_de_oficio, Data_Orientacao, Prazo, Obs,
                        CASE
                            WHEN CONVERT(DATE, GETDATE()) > CONVERT(DATE, Prazo) THEN 'VENCEU'
                            WHEN CONVERT(DATE, GETDATE()) = CONVERT(DATE, Prazo) THEN 'VENCEU HOJE'
                            ELSE (CAST(DATEDIFF(DAY, CONVERT(DATE, GETDATE()), CONVERT(DATE, Prazo)) AS NVARCHAR) + ' DIAS PARA VENCER') 
                        END AS Alerta,
                        CASE
                            WHEN Obs = 'CUMPRIDA' THEN 'CUMPRIDA'
                            WHEN Obs = 'NÃO CUMPRIDA' THEN 'NÃO CUMPRIDA'
                            ELSE ''
                        END AS [Grau de comprimento]
                    FROM
                        tbl_Depart_Est_Plan_Anal WHERE Num=@id or conteudo_Despacho LIKE '%'+@conteudoDespacho+'%' ORDER BY Num DESC";
                connection.Open();
                command.CommandText = query;
                command.Parameters.Add("@id", SqlDbType.Int).Value = depaId;
                command.Parameters.Add("@conteudoDespacho", SqlDbType.NVarChar).Value = conteudoDespacho;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var depaModel = new DepaModel();
                        depaModel.Id = (int)reader[0];
                        depaModel.Assunto = reader[1].ToString();
                        depaModel.Conteudo_despacho = reader[2].ToString();
                        depaModel.Area_afectada = reader[3].ToString();
                        depaModel.Numero_de_oficio = reader[4].ToString();
                        depaModel.Data_orientacao = DateTime.Parse(reader[5].ToString());
                        depaModel.Prazo = DateTime.Parse(reader[6].ToString());
                        depaModel.Obs = reader[7].ToString();
                        depaModel.Alerta = reader[8].ToString();
                        depaModel.GrauCumprimento = reader[9].ToString();
                        depaList.Add(depaModel);
                    }
                }
            }
            return depaList;
        }

        public int getNotificationTime() {

            int notificationTime = 1;

            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                string query = @"SELECT * FROM notificacoes WHERE id = 1";
                connection.Open();
                command.CommandText = query;
                using (var reader = command.ExecuteReader())
                {
                    reader.Read();
                    notificationTime = (int)reader[1];
                }
            }

            return notificationTime;
        }

        public void setNotificationTime(int time) {

            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                string query = "UPDATE notificacoes SET tempo=@tempo WHERE id=1";
                connection.Open();
                command.CommandText = query;
                command.Parameters.Add("@tempo", SqlDbType.Int).Value = time;
                command.ExecuteNonQuery();
            }
        }

        public int CountAlerts()
        {
            var depaList = new List<DepaModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();

                string query = @"CREATE OR ALTER VIEW notifications AS
                SELECT Num, Assunto, Prazo,
                        CASE
                            WHEN CONVERT(DATE, GETDATE()) > CONVERT(DATE, Prazo) THEN 'VENCEU'
                            WHEN CONVERT(DATE, GETDATE()) = CONVERT(DATE, Prazo) THEN 'VENCEU HOJE'
                            ELSE (CAST(DATEDIFF(DAY, CONVERT(DATE, GETDATE()), CONVERT(DATE, Prazo)) AS NVARCHAR) + ' DIAS PARA VENCER') 
                        END AS Alerta,
                        CASE
                            WHEN Obs = 'CUMPRIDA' THEN 'CUMPRIDA'
                            WHEN Obs = 'NÃO CUMPRIDA' THEN 'NÃO CUMPRIDA'
                            ELSE ''
                        END AS [Grau de comprimento]
                    FROM
                        tbl_Depart_Est_Plan_Anal";

                command.CommandText = query;
                command.ExecuteNonQuery();

                query = @"select * FROM notifications WHERE Alerta = 'VENCEU'";
                command.CommandText = query;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var depaModel = new DepaModel();
                        depaModel.Id = (int)reader[0];
                        depaModel.Assunto = reader[1].ToString();
                        depaModel.Prazo = DateTime.Parse(reader[2].ToString());
                        depaModel.Alerta = reader[3].ToString();
                        depaModel.GrauCumprimento = reader[4].ToString();
                        depaList.Add(depaModel);
                    }
                }
            }
            return depaList.Count;
        }
    }
}
