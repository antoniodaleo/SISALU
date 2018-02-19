using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISALU.BLL.Exceptions
{
    public class TurnoNaoCadastradoException:Exception
    {

        public TurnoNaoCadastradoException() { 
        
        }

        public TurnoNaoCadastradoException(string message)
        :base(message){

        }


    }
}
