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
    public class AlunoBO
    {


        private AlunoDAO _alunoDAO;


        public Aluno preencherAlunoPorCodigo(int codigo) {
            _alunoDAO = new AlunoDAO(); //instanciar a DAO
           var aluno = new Aluno();
           aluno = _alunoDAO.obterAlunoPorCodigo(codigo);

            if (aluno == null)
            {
                throw new AlunoNaoCadastradoException();
            } else {

                return aluno;
            
            }

        
        }


        public List<Aluno> listarTodosAlunos() {

            _alunoDAO = new AlunoDAO();

            return _alunoDAO.obterTodosAlunos();

        
        }



        public void inserirNovoAluno(Aluno aluno)
        {
            var _alunoDAO = new AlunoDAO();

            validarAluno(aluno);

            if(_alunoDAO.inserirAluno(aluno)==0){
                throw new AlunoNaoCadastradoException();
            }


        }

        private void validarAluno(Aluno aluno)
        {

            if (string.IsNullOrWhiteSpace(aluno.Nome))
            {
                throw new AlunoInvalidoException();
            }

        }

    }
}
