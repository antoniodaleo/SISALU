using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISALU.BLL.Exceptions
{
    public class AlunoInvalidoException:Exception
    {
        public AlunoInvalidoException()
        {

        }

        public AlunoInvalidoException(string message)
            :base(message)
        {

        }


    }
}
