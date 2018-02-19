using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISALU.Model;
using SISALU.BLL.Exceptions;
using SISALU.DAL;

namespace SISALU.BLL.Sistema
{
    public class MatriculaBO
    {

        private MatriculaDAO _matriculaDAO;
        
        public void realizarNovaMatricula(Matricula matricula)
        {
            _matriculaDAO = new MatriculaDAO();

            validarMatricula(matricula);

            int linhas = _matriculaDAO.efetuarMatricula(matricula); 

            if(linhas==0){
                throw new MatriculaNaoEfetuadaException();
            }


        }

        private void validarMatricula(Matricula matricula)
        {
            if (
                matricula.IdAluno<=0 || 
                matricula.IdCurso<=0 ||
                matricula.IdTurno<=0 ||
                matricula.IdTurma<=0 ||
                matricula.Valor <= 49
                )
            {
                throw new MatriculaInvalidaException();
            }
            


        }


    }
}
