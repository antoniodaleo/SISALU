using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SISALU.Model;
using SISALU.BLL;
using SISALU.BLL.Exceptions;
using SISALU.BLL.Sistema;

namespace SISALU.Sistema.Cadastros
{
    public partial class alunos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {

            var aluno = new Aluno();

            try
            {
                try
                {
                    aluno.Nome = Convert.ToString(txtNome.Text);
                    aluno.Email = Convert.ToString(txtEmail.Text);
                    aluno.DataNasc = Convert.ToDateTime(txtDataNasc.Text);
                    aluno.Telefone = Convert.ToString(txtTelefone.Text);
                    aluno.Celular = Convert.ToString(txtCelular.Text);
                    aluno.Endereco = Convert.ToString(txtEndereco.Text);
                    aluno.Numero = Convert.ToInt32(txtNumero.Text);
                    aluno.Bairro = Convert.ToString(dpBairro.SelectedValue);
                    aluno.Complemento = Convert.ToString(txtComplemento.Text);

                    var alunoBO = new AlunoBO();

                    alunoBO.inserirNovoAluno(aluno);

                    lblMensagem.Text = "Aluno Cadastrado com sucesso!";


                }
                catch (AlunoInvalidoException)
                { 
                    lblMensagem.Text = "Erro no preenchimento dos Campos!";
                }


            }catch(AlunoNaoCadastradoException){
                lblMensagem.Text = "Erro ao Cadastrar o Aluno!";
            }
            

        }
    }
}