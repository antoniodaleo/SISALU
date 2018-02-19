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
    public class CursoBO
    {

        public List<Curso> listarTodosCursos()
        {

            var cursoDAO = new CursoDAO();
            var listarCurso = new List<Curso>();

            listarCurso = cursoDAO.obterTodosCursos();

            if (listarCurso == null)
            {
                throw new CursoNaoCadastradoException();
            }
            else
            {
                return listarCurso;
            }

        } 

    }
}
