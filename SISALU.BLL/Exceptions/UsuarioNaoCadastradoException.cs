using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISALU.BLL.Exceptions
{
    public class UsuarioNaoCadastradoException:Exception
    {
        public UsuarioNaoCadastradoException()
        {

        }

        public UsuarioNaoCadastradoException(string message)
            :base(message)
        {

        }


    }
}
