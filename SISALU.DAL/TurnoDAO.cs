using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SISALU.Model;

namespace SISALU.DAL
{
   public class TurnoDAO
    {

        public List<Turno> obterTodosTurnos()
        {
            try
            {

                var command = new SqlCommand();
                command.Connection = ConnectionFactory._connection;

                command.CommandText = "SELECT *FROM turno";

                var listaTurno = new List<Turno>();

                ConnectionFactory.Conectar();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {

                    var turno = new Turno();

                    turno.Id = Convert.ToInt32(reader["id"]);
                    turno.Descricao = Convert.ToString(reader["descricao"]);
                    turno.DataCad = Convert.ToDateTime(reader["data_cad"]);

                    listaTurno.Add(turno);

                }
                reader.Close();
                return listaTurno;


            }
            catch (Exception)
            {

                throw;
            }

        }



        public int inserirTurno(Turno turno)
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = ConnectionFactory._connection;

                command.CommandText = @"INSERT INTO turno
                                      (descricao)VALUES(@DESCRICAO)";

                command.Parameters.AddWithValue("@DESCRICAO", turno.Descricao);
          
                ConnectionFactory.Conectar();

                return command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
