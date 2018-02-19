using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISALU.BLL.Exceptions
{
    public class TurmaInvalidaException:Exception
    {
        public TurmaInvalidaException() { 
        
        }

        public TurmaInvalidaException(string message)
            :base(message)
        {

        }

       

    }
}
