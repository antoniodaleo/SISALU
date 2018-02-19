using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISALU.DAL;
using SISALU.Model;
using SISALU.BLL.Exceptions;



namespace SISALU.BLL
{

    public class LoginBO
    {

        private UsuarioDAO _usuarioDAO;

        public Usuario obterUsuarioparaLogar(string login,string senha)
        {
            var usuario = new Usuario();
            _usuarioDAO = new UsuarioDAO();

            usuario = _usuarioDAO.ObterUsuarioNoBanco(login,senha);

            if (usuario == null)
            {
                throw new UsuarioNaoCadastradoException();
            }
            else {
               
                return usuario;
            
            }
        }

    }
    
}
