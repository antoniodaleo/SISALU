using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISALU.DAL;
using SISALU.Model;
using SISALU.BLL.Exceptions;


namespace SISALU.BLL.Sistema
{
    public class TurmaBO
    {


        public List<Turma> listarTodasTurmas()
        {

            var turmaDAO = new TurmaDAO();
            var listaTurma = new List<Turma>();
           
            listaTurma = turmaDAO.obterTodasTurmas();

            if (listaTurma == null)
            {
                throw new TurmaNaoCadastradaException();
            }
            else
            {
                return listaTurma;
            }
 


        }


        public void inserirNovaTurma(Turma turma)
        {
            var _turmaDAO = new TurmaDAO();

            validarTurma(turma);

            if (_turmaDAO.inserirTurma(turma) == 0)
            {
                throw new TurmaNaoCadastradaException();
            }


        }



        private void validarTurma(Turma turma) {

            if (string.IsNullOrWhiteSpace(turma.Descricao) || turma.QuantAlunos<=0)
            {
                throw new TurmaInvalidaException();
            }

        }


    }
}
