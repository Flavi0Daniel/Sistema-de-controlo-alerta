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
    public class DEPARepository : BaseRepository, IDEPARepository
    {

        // Constructor
        public DEPARepository(string connectionString) {
            this.connectionString = connectionString;
        }

        // Methods
        public void Add(DEPAModel depa)
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

        public void Edit(DEPAModel depa)
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

        public IEnumerable<DEPAModel> GetAll()
        {
            var depaList = new List<DEPAModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand()) {
                string query = "SELECT * FROM tbl_Depart_Est_Plan_Anal ORDER BY Num DESC";
                connection.Open();
                command.CommandText = query;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var depaModel = new DEPAModel();
                        depaModel.Id = (int)reader[0];
                        depaModel.Assunto = reader[1].ToString();
                        depaModel.Conteudo_despacho = reader[2].ToString();
                        depaModel.Area_afectada = reader[3].ToString();
                        depaModel.Numero_de_oficio = reader[4].ToString();
                        depaModel.Data_orientacao = DateTime.Parse(reader[5].ToString());
                        depaModel.Prazo = DateTime.Parse(reader[6].ToString());
                        depaModel.Obs = reader[7].ToString();
                        depaList.Add(depaModel);
                    }
                }
            }
            return depaList;
        }

        public IEnumerable<DEPAModel> GetByValue(string value)
        {
            var depaList = new List<DEPAModel>();
            int depaId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string depaAssunto = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                string query = @"SELECT * FROM tbl_Depart_Est_Plan_Anal WHERE Num=@id or Assunto LIKE '%'+@assunto+'%' ORDER BY Num DESC";
                connection.Open();
                command.CommandText = query;
                command.Parameters.Add("@id", SqlDbType.Int).Value = depaId;
                command.Parameters.Add("@assunto", SqlDbType.NVarChar).Value = depaAssunto;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var depaModel = new DEPAModel();
                        depaModel.Id = (int)reader[0];
                        depaModel.Assunto = reader[1].ToString();
                        depaModel.Conteudo_despacho = reader[2].ToString();
                        depaModel.Area_afectada = reader[3].ToString();
                        depaModel.Numero_de_oficio = reader[4].ToString();
                        depaModel.Data_orientacao = DateTime.Parse(reader[5].ToString());
                        depaModel.Prazo = DateTime.Parse(reader[6].ToString());
                        depaModel.Obs = reader[7].ToString();
                        depaList.Add(depaModel);
                    }
                }
            }
            return depaList;
        }
    }
}
