using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SISALU.Model;

namespace SISALU.DAL
{
    public class CursoDAO
    {

        public List<Curso> obterTodosCursos()
        {
            try
            {

                var command = new SqlCommand();
                command.Connection = ConnectionFactory._connection;

                command.CommandText = "SELECT *FROM curso";

                var listaCurso = new List<Curso>();

                ConnectionFactory.Conectar();

                var reader = command.ExecuteReader();
               

                while (reader.Read())
                {

                    var curso = new Curso();

                    curso.Id = Convert.ToInt32(reader["id"]);
                    curso.Descricao = Convert.ToString(reader["descricao"]);
                    curso.CargaHoraria = Convert.ToInt32(reader["cargaHoraria"]);
                    curso.DataCad = Convert.ToDateTime(reader["data_cad"]);

                    listaCurso.Add(curso);

                }
                reader.Close();
                return listaCurso;
               

            }
            catch (Exception)
            {

                throw;
            }

        }



        public int inserirCurso(Curso curso)
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = ConnectionFactory._connection;

                command.CommandText = @"INSERT INTO curso
           (descricao
           ,cargaHoraria
           )
     VALUES
           (@DESCRICAO
           ,@CARGAHORARIA
           )";

                command.Parameters.AddWithValue("@DESCRICAO", curso.Descricao);
                command.Parameters.AddWithValue("@CARGAHORARIA", curso.CargaHoraria);


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
