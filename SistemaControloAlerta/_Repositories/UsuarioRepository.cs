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
    public class UsuarioRepository : BaseRepository, IusuarioRepository
    {

        // Constructor
        public UsuarioRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods
        //public void Add(UsuarioModel usuario)
        //{
        //    using (var connection = new SqlConnection(connectionString))
        //    using (var command = connection.CreateCommand())
        //    {
        //        string query = "INSERT INTO tbl_usuarios values(@acesso, @senha)";
        //        connection.Open();
        //        command.CommandText = query;
        //        command.Parameters.Add("@acesso", SqlDbType.Int).Value = usuario.NivelDeAcesso;
        //        command.Parameters.Add("@senha", SqlDbType.NVarChar).Value = usuario.Senha;
        //        command.ExecuteNonQuery();
        //    }
        //}

        //public void Delete(int id)
        //{
        //    using (var connection = new SqlConnection(connectionString))
        //    using (var command = connection.CreateCommand())
        //    {
        //        string query = "DELETE FROM tbl_usuarios WHERE id=@id";
        //        connection.Open();
        //        command.CommandText = query;
        //        command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        //        command.ExecuteNonQuery();
        //    }
        //}

        public void Edit(UsuarioModel usuario)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                string query = "UPDATE tbl_usuarios SET acesso=@acesso, senha=@senha WHERE id=@id";
                connection.Open();
                command.CommandText = query;
                command.Parameters.Add("@acesso", SqlDbType.Int).Value = usuario.NivelDeAcesso;
                command.Parameters.Add("@senha", SqlDbType.NVarChar).Value = usuario.Senha;
                command.Parameters.Add("@id", SqlDbType.Int).Value = usuario.Id;
                command.ExecuteNonQuery();
            }
        }

        public UsuarioModel GetById(int id)
        {
            var usuarioModel = new UsuarioModel();

            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                string query = "SELECT * FROM tbl_usuarios WHERE id=@id";
                connection.Open();
                command.CommandText = query;
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                using (var reader = command.ExecuteReader())
                {
                    reader.Read();

                    usuarioModel.Id = (int)reader[0];
                    usuarioModel.NivelDeAcesso = (int)reader[1];
                    usuarioModel.Senha = reader[2].ToString();
                }

                return usuarioModel;
            }
        }

        //public IEnumerable<UsuarioModel> GetAll()
        //{
        //    var usuarioList = new List<UsuarioModel>();
        //    using (var connection = new SqlConnection(connectionString))
        //    using (var command = connection.CreateCommand())
        //    {
        //        string query = @"SELECT * FROM tbl_usuarios";
        //        connection.Open();
        //        command.CommandText = query;
        //        using (var reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                var usuarioModel = new UsuarioModel();
        //                usuarioModel.Id = (int)reader[0];
        //                usuarioModel.NivelDeAcesso = (int)reader[1];
        //                usuarioModel.Senha = reader[2].ToString();
        //                usuarioList.Add(usuarioModel);
        //            }
        //        }
        //    }
        //    return usuarioList;
        //}

        //public IEnumerable<NiveisAcesso> GetAccessLevels()
        //{
        //    var niveisAcessos = new List<NiveisAcesso>();

        //    using (var connection = new SqlConnection(connectionString))
        //    using (var command = connection.CreateCommand())
        //    {
        //        string query = @"SELECT * FROM tbl_niveis_acesso";
        //        connection.Open();
        //        command.CommandText = query;
        //        using (var reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                var niveisAcessoModel = new NiveisAcesso();
        //                niveisAcessoModel.Id = (int)reader[0];
        //                niveisAcessoModel.NivelDeAcesso = reader[1].ToString();
        //                niveisAcessos.Add(niveisAcessoModel);
        //            }
        //        }
        //    }
        //    return niveisAcessos;
        //}
    }
}
