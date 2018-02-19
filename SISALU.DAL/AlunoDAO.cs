using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISALU.Model;
using System.Data.SqlClient;

namespace SISALU.DAL
{
   public class AlunoDAO
    {




       public Aluno obterAlunoPorCodigo(int codigo){

           try
           {

               var command = new SqlCommand();
               command.Connection = ConnectionFactory._connection;

               command.CommandText = "SELECT * FROM aluno WHERE id=@CODIGO";

               command.Parameters.AddWithValue("@CODIGO", codigo);

               ConnectionFactory.Conectar();

               var reader = command.ExecuteReader();

               //aluno sem dados
               Aluno aluno = null;

               while (reader.Read())
               {
                   //aluno com dados
                   aluno = new Aluno();
                   aluno.Id = Convert.ToInt32(reader["id"]);
                   aluno.Nome = Convert.ToString(reader["nome"]);
                   aluno.Email = Convert.ToString(reader["email"]);
                   aluno.Telefone = Convert.ToString(reader["telefone"]);
                   aluno.Celular = Convert.ToString(reader["celular"]);

               }

               return aluno;


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




       public List<Aluno> obterTodosAlunos()
       {
           try
           {

               var command = new SqlCommand();
               command.Connection = ConnectionFactory._connection;

               command.CommandText = "SELECT *FROM aluno";

               var listaAluno = new List<Aluno>();

               ConnectionFactory.Conectar()
                   ;

               var reader = command.ExecuteReader();

               while (reader.Read())
               {

                   var aluno = new Aluno();

                   aluno.Id = Convert.ToInt32(reader["id"]);
                   aluno.Nome = Convert.ToString(reader["nome"]);
                   aluno.Email = Convert.ToString(reader["email"]);
                   aluno.DataNasc = Convert.ToDateTime(reader["dataNasc"]);
                   aluno.Telefone = Convert.ToString(reader["telefone"]);
                   aluno.Celular = Convert.ToString(reader["celular"]);
                   aluno.Endereco = Convert.ToString(reader["endereco"]);
                   aluno.Numero = Convert.ToInt32(reader["numero"]);
                   aluno.Bairro = Convert.ToString(reader["bairro"]);
                   aluno.Complemento = Convert.ToString(reader["complemento"]);
                   aluno.DataCad = Convert.ToDateTime(reader["data_cad"]);

                   listaAluno.Add(aluno);

               }

               return listaAluno;


           }
           catch (Exception)
           {
               
               throw;
           }

       }


       public int inserirAluno(Aluno aluno)
       {
           try
           {
               var command = new SqlCommand();
               command.Connection = ConnectionFactory._connection;

               command.CommandText = @"INSERT INTO aluno
           (nome
           ,email
           ,dataNasc
           ,telefone
           ,celular
           ,endereco
           ,numero
           ,bairro
           ,complemento
           )
     VALUES
           (@NOME
           ,@EMAIL
           ,@DATANASC
           ,@TELEFONE
           ,@CELULAR
           ,@ENDERECO
           ,@NUMERO
           ,@BAIRRO
           ,@COMPLEMENTO
           )";

               command.Parameters.AddWithValue("@NOME",aluno.Nome);
               command.Parameters.AddWithValue("@EMAIL", aluno.Email);
               command.Parameters.AddWithValue("@DATANASC", aluno.DataNasc);
               command.Parameters.AddWithValue("@TELEFONE", aluno.Telefone);
               command.Parameters.AddWithValue("@CELULAR", aluno.Celular);
               command.Parameters.AddWithValue("@ENDERECO", aluno.Endereco);
               command.Parameters.AddWithValue("@NUMERO", aluno.Numero);
               command.Parameters.AddWithValue("@BAIRRO", aluno.Bairro);
               command.Parameters.AddWithValue("@COMPLEMENTO", aluno.Complemento);

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
