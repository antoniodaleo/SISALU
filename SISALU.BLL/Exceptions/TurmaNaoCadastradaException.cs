using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISALU.BLL.Exceptions
{
    public class TurmaNaoCadastradaException:Exception
    {

        public TurmaNaoCadastradaException() { 
        
        }
        
        public TurmaNaoCadastradaException(string message)
            :base(message)
        {

        }

    }
}
