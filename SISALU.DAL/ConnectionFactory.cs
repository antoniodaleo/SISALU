using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace SISALU.DAL
{
    public class ConnectionFactory
    {

        public static string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString;
        public static SqlConnection _connection = new SqlConnection(_connectionString);

        public static void Conectar()
        {

            if(_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }

        }

        public static void Desconectar()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }                                                                        
        }
        

    }
}
