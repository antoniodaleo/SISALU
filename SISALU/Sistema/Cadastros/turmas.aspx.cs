using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SISALU.BLL.Exceptions;
using SISALU.Model;
using SISALU.BLL.Sistema;

namespace SISALU.Sistema.Cadastros
{
    public partial class turmas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            var turma = new Turma();

            try
            {
                try
                {
                   
                    turma.Descricao = Convert.ToString(txtDescricao.Text);
                    turma.QuantAlunos = Convert.ToInt32(txtQuantAlunos.Text);

                }
                catch (TurmaInvalidaException)
                {

                    lblMensagem.Text = "Erro no preenchimento dos Campos!";
                }

                var turmaBO = new TurmaBO();
                turmaBO.inserirNovaTurma(turma);
                lblMensagem.Text = "Turma Cadastrada com Sucesso!";

            }
            catch (TurmaNaoCadastradaException)
            {

                lblMensagem.Text = "Erro ao cadastrar a turma no Sistema!";
            }

        }
    }
}