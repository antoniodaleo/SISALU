using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISALU.Model;
using System.Data.SqlClient;


namespace SISALU.DAL
{
    public class UsuarioDAO
     {

        public Usuario ObterUsuarioNoBanco(string login,string senha)
        {

            try
            {
                var command = new SqlCommand();
                command.Connection = ConnectionFactory._connection;

                command.CommandText = "SELECT * FROM usuario WHERE login=@LOGIN AND senha=@SENHA;";
                command.Parameters.AddWithValue("@LOGIN", login);
                command.Parameters.AddWithValue("@SENHA", senha);

                ConnectionFactory.Conectar();

                Usuario user = null;

                var reader = command.ExecuteReader(); //executeQuery

                while (reader.Read())
                {
                    user = new Usuario();

                    user.Id = Convert.ToInt32(reader["id"]);
                    user.Nome = Convert.ToString(reader["nome"]);
                    user.Login = Convert.ToString(reader["login"]);
                    user.Senha = Convert.ToString(reader["senha"]);
                    user.Nivel = Convert.ToString(reader["nivel"]);

                }

                return user;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ConnectionFactory.Desconectar();
            }
           
        }
       

     }

        
}

