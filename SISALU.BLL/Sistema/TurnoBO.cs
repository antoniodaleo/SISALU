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
    public class TurnoBO
    {

        public List<Turno> listarTodosTurnos()
        {

            var turnoDAO = new TurnoDAO();
            var listarTurno = new List<Turno>();

            listarTurno = turnoDAO.obterTodosTurnos();

            if (listarTurno == null)
            {
                throw new TurnoNaoCadastradoException();
            }
            else
            {
                return listarTurno;
            }

        } 

    }
}
