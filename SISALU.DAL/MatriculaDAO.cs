using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SISALU.Model;

namespace SISALU.DAL
{
    public class MatriculaDAO
    {


        public int efetuarMatricula(Matricula matricula) {

            try
            {
                var command = new SqlCommand();
                command.Connection = ConnectionFactory._connection;

                command.CommandText = @"INSERT INTO matricula
                                   (aluno
                                   ,curso
                                   ,turno
                                   ,turma
                                   ,valor
                                   )
                             VALUES
                                   (@ALUNO
                                   ,@CURSO
                                   ,@TURNO
                                   ,@TURMA
                                   ,@VALOR
                                   )";
                command.Parameters.AddWithValue("@ALUNO", matricula.IdAluno);
                command.Parameters.AddWithValue("@CURSO", matricula.IdCurso);
                command.Parameters.AddWithValue("@TURNO", matricula.IdTurno);
                command.Parameters.AddWithValue("@TURMA", matricula.IdTurma);
                command.Parameters.AddWithValue("@VALOR", matricula.Valor);

                ConnectionFactory.Conectar();

                return command.ExecuteNonQuery();



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
