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
    public partial class matricula : System.Web.UI.Page
    {

        private AlunoBO _alunoBO;
        private Aluno _aluno;
        private MatriculaBO _matriculaBO; 

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                CarregarCursoNaDropList();
                CarregarTurmaNaDropList();
                CarregarTurnoNaDropList();
            }

        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {

                var cod = txtCodigo.Text;

                _aluno = new Aluno();
                _alunoBO = new AlunoBO();

                _aluno = _alunoBO.preencherAlunoPorCodigo(Convert.ToInt32(cod));

                //preencher os campos da página
                txtNome.Text = _aluno.Nome;
                txtEmail.Text = _aluno.Email;
                txtTelefone.Text = _aluno.Telefone;
                txtCelular.Text = _aluno.Celular;

                lblMensagem.Text = "Pesquisa Concluida!";

            }
            catch (AlunoNaoCadastradoException)
            {

                lblMensagem.Text = "Aluno não Encontrado!";

            }

        }


        //metodo para preencher os dropDawn
        private void CarregarCursoNaDropList()
        {
            var cursoBO = new CursoBO();
            dpCurso.DataSource = cursoBO.listarTodosCursos();
            dpCurso.DataBind(); //carregar os dados da fonte (dataSource)
        }

        //metodo para preencher os dropDawn
        private void CarregarTurmaNaDropList()
        {
            var turmaBO = new TurmaBO();
            dpTurma.DataSource = turmaBO.listarTodasTurmas();
            dpTurma.DataBind();
        }

        private void CarregarTurnoNaDropList()
        {
            var turnoBO = new TurnoBO();
            dpTurno.DataSource = turnoBO.listarTodosTurnos();
            dpTurno.DataBind();
        }


        private void limpar() 
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtValor.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtCelular.Text = "";
            btnCadastrar.Enabled = false; 
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var matric = new Matricula(); 
                matric.IdAluno = Convert.ToInt32(txtCodigo.Text);
                matric.Valor = Convert.ToDecimal(txtValor.Text);

                matric.IdCurso = Convert.ToInt32(dpCurso.SelectedValue);
                matric.IdTurno = Convert.ToInt32(dpTurno.SelectedValue);
                matric.IdTurma = Convert.ToInt32(dpTurma.SelectedValue);

                try
                {
                    _matriculaBO = new MatriculaBO(); 

                    _matriculaBO.realizarNovaMatricula(matric);
                    lblMensagem.Text = "Matricula efetuada com sucesso";

                    limpar(); 
                }
                catch (MatriculaNaoEfetuadaException)
                {
                    
                     lblMensagem.Text = "Problema na matricula do aluno!";
                }


            }
            catch (MatriculaInvalidaException)
            {

                lblMensagem.Text = "Erro no preenchimento dos campos!";
            }
  


        }


    }
}
