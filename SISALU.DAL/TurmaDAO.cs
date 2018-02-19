using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SISALU.Model;

namespace SISALU.DAL
{
    public class TurmaDAO
    {


        public List<Turma> obterTodasTurmas()
        {
            try
            {

                var command = new SqlCommand();
                command.Connection = ConnectionFactory._connection;

                command.CommandText = "SELECT * FROM turma";



                ConnectionFactory.Conectar();
                var reader = command.ExecuteReader();

                var listaTurma = new List<Turma>();

                while (reader.Read())
                {

                    var turma = new Turma();

                    turma.Id = Convert.ToInt32(reader["id"]);
                    turma.Descricao = Convert.ToString(reader["descricao"]);
                    turma.QuantAlunos = Convert.ToInt32(reader["quantAlunos"]);
                    turma.DataCad = Convert.ToDateTime(reader["data_cad"]);

                    listaTurma.Add(turma);

                }
                    reader.Close();
                   
                return listaTurma;
                



            }
            catch (Exception)
            {

                throw;
            }
           

        }



        public int inserirTurma(Turma turma)
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = ConnectionFactory._connection;

                command.CommandText = @"INSERT INTO turma
           (descricao
           ,quantAlunos
           )
     VALUES
           (@DESCRICAO
           ,@QUANTALUNOS
           )";

                command.Parameters.AddWithValue("@DESCRICAO", turma.Descricao);
                command.Parameters.AddWithValue("@QUANTALUNOS", turma.QuantAlunos);
              

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
