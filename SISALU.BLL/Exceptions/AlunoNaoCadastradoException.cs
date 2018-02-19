using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISALU.BLL.Exceptions
{
    public class AlunoNaoCadastradoException:Exception
    {
        public AlunoNaoCadastradoException()
        {

        }

        public AlunoNaoCadastradoException(string message)
            :base(message)
        {

        }


    }
}
