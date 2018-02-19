using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SISALU.BLL;
using SISALU.Model;
using SISALU.BLL.Exceptions;
using System.Web.Security;



namespace SISALU.Autenticacao
{
    public partial class Login : System.Web.UI.Page
    {


        private LoginBO _loginBO;
 

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {

            var login = txtLogin.Text;
            var senha = txtSenha.Text;
            
            try
            {
                var usuario = new Usuario();
                _loginBO = new LoginBO();
         

                usuario = _loginBO.obterUsuarioparaLogar(login, senha);
                FormsAuthentication.RedirectFromLoginPage(login,false);



            }catch(UsuarioNaoCadastradoException){
                lblMensagem.Text = "Usuário não cadastrado!";
            }
            catch (Exception)
            {
                lblMensagem.Text = "Ocorreu um erro inesperado no LogIn.";
            }

        }
    }
}