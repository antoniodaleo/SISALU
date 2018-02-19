<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="matricula.aspx.cs" Inherits="SISALU.Sistema.Cadastros.matricula" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> SISALU® - Sistema de Controle de Alunos </title>
    <link href="../../Css/sisalu.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    
         <div class="header">
            <h1> SISALU® Sistema de Controle de Alunos</h1>
             <p><span class="titulo"> [ Matricula de Alunos ] </span></p>
        </div>
        <div class="conteudo">
            <a href="../default.aspx">Voltar ao Menu</a>
         <div class="painel">

                  <asp:Label ID="lblMensagem" runat="server" CssClass="error"></asp:Label>
                  <br />  <br />
                 
                <div class="controlCod">
                    <asp:Label ID="Label5" runat="server" Text="Codigo Aluno"></asp:Label><br />
                    <asp:TextBox ID="txtCodigo" runat="server" CssClass="controlInput"></asp:TextBox>
                    <asp:Button ID="btnPesquisar" runat="server" Text="Buscar ..." CssClass="controlBotao" OnClick="btnPesquisar_Click"></asp:Button>
                </div> 

                <div class="control">
                    <asp:Label ID="Label1" runat="server" Text="Nome Completo"></asp:Label>
                    <asp:TextBox ID="txtNome" runat="server" ReadOnly="True"></asp:TextBox>
                </div>
                 <div class="control">
                    <asp:Label ID="Label2" runat="server" Text="E-mail"></asp:Label>
                    <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" ReadOnly="True"></asp:TextBox>
                </div>
                 <div class="control">
                    <asp:Label ID="Label3" runat="server" Text="Telefone (Residencial)"></asp:Label>
                    <asp:TextBox ID="txtTelefone" runat="server" TextMode="Phone" ReadOnly="True"></asp:TextBox>
                </div>
                 <div class="control">
                    <asp:Label ID="Label4" runat="server" Text="Celular (WhastApp)"></asp:Label>
                    <asp:TextBox ID="txtCelular" runat="server" TextMode="Phone" ReadOnly="True"></asp:TextBox>
                </div>

                 <div class="control">
                    <asp:Label ID="Label6" runat="server" Text="Curso Técnico"></asp:Label>
                    <asp:DropDownList ID="dpCurso" runat="server"  DataValueField="Id" DataTextField="Descricao" ></asp:DropDownList>
                </div>

                <div class="control">
                    <asp:Label ID="Label7" runat="server" Text="Escolha o Turno"></asp:Label>
                    <asp:DropDownList ID="dpTurno" runat="server"  DataValueField="Id" DataTextField="Descricao" ></asp:DropDownList>
                </div>

                 <div class="control">
                    <asp:Label ID="Label8" runat="server" Text="Escolha a Turma"></asp:Label>
                    <asp:DropDownList ID="dpTurma" runat="server"  DataValueField="Id" DataTextField="Descricao"></asp:DropDownList>
                </div>

             <div class="control">
                    <asp:Label ID="Label9" runat="server" Text="Valor da Matricula"></asp:Label>
                    <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
                </div>

                 <div class="controle">
                    <asp:Button ID="btnCadastrar" runat="server" Text="Realizar Matricula" OnClick="btnCadastrar_Click"></asp:Button>
                    <a href="../default.aspx" class="linkmenu" > Voltar ao Menu </a>
                 </div>


            </div><!-- fim do painel -->
    </div>
    </form>
    </body>
</html>
