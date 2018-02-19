using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISALU.BLL.Exceptions
{
    public class MatriculaInvalidaException:Exception
    {
        public MatriculaInvalidaException() {
        
        }
        public MatriculaInvalidaException(string message)
        :base(message){
             
        }

    }
}
