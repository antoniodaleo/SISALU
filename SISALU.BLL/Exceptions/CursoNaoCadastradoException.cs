using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISALU.BLL.Exceptions
{
    public class CursoNaoCadastradoException:Exception
    {
        public CursoNaoCadastradoException()
        {

        }

        public CursoNaoCadastradoException(string message)
        :base(message){

        }


    }
}
