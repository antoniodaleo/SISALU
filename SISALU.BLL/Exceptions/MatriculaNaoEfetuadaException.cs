using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISALU.BLL.Exceptions
{
    public class MatriculaNaoEfetuadaException:Exception
    {
        public MatriculaNaoEfetuadaException()
        {

        }

        public MatriculaNaoEfetuadaException(string message)
        :base(message){

        }

    }
}
