<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="alunos.aspx.cs" Inherits="SISALU.Sistema.Cadastros.alunos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> SISALU® - Sistema de Controle de Alunos </title>
    <link href="../../Css/sisalu.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
       
     <div>
        <div class="header">
            <h1> SISALU® Sistema de Controle de Alunos</h1>
             <p><span class="titulo"> [ Cadastro de Novos Alunos ] </span></p>
        </div>
        <div class="conteudo">
              
            <div class="painel">

                  <asp:Label ID="lblMensagem" runat="server" CssClass="error"></asp:Label>
                  <br />  <br /> 

                <div class="control">
                    <asp:Label ID="Label1" runat="server" Text="Nome Completo"></asp:Label>
                    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                </div>
                 <div class="control">
                    <asp:Label ID="Label2" runat="server" Text="E-mail"></asp:Label>
                    <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
                </div>
                 <div class="control">
                    <asp:Label ID="Label3" runat="server" Text="Telefone (Residencial)"></asp:Label>
                    <asp:TextBox ID="txtTelefone" runat="server" TextMode="Phone"></asp:TextBox>
                </div>
                 <div class="control">
                    <asp:Label ID="Label4" runat="server" Text="Celular (WhastApp)"></asp:Label>
                    <asp:TextBox ID="txtCelular" runat="server" TextMode="Phone"></asp:TextBox>
                </div>

                <div class="control">
                    <asp:Label ID="Label5" runat="server" Text="Data Nascimento"></asp:Label>
                    <asp:TextBox ID="txtDataNasc" runat="server" TextMode="Date"></asp:TextBox>
                </div>

                <div class="control">
                    <asp:Label ID="Label6" runat="server" Text="Endereço Completo"></asp:Label>
                    <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
                </div>
                 <div class="control">
                    <asp:Label ID="Label8" runat="server" Text="Numero"></asp:Label>
                    <asp:TextBox ID="txtNumero" runat="server" TextMode="Number"></asp:TextBox>
                </div>

                <div class="control">
                    <asp:Label ID="Label7" runat="server" Text="Bairro"></asp:Label>
                    <asp:DropDownList ID="dpBairro" runat="server">
                        <asp:ListItem> </asp:ListItem>
                        <asp:ListItem>Araturi</asp:ListItem>
                        <asp:ListItem>Metropole</asp:ListItem>
                        <asp:ListItem>Centro</asp:ListItem>
                        <asp:ListItem>Messejana</asp:ListItem>
                        <asp:ListItem>Jose Walter</asp:ListItem>
                        <asp:ListItem>Antônio Bezerra</asp:ListItem>
                        <asp:ListItem>Siqueira</asp:ListItem>
                        <asp:ListItem>Mucuripe</asp:ListItem>
                        <asp:ListItem>Vila Velha</asp:ListItem>
                        <asp:ListItem>Aldeota</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="control">
                    <asp:Label ID="Label9" runat="server" Text="Complemento"></asp:Label>
                    <asp:TextBox ID="txtComplemento" runat="server"></asp:TextBox>
                </div>

                 <div class="controle">
                    <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click"></asp:Button>
                    <a href="../default.aspx" class="linkmenu" > Voltar ao Menu </a>
                 </div>


            </div><!-- fim do painel -->
          
        </div>
         <div class="rodape"> 
             <p>SISALU - Sistema de Controle de ALunos 2018 - Desenvolvido por Turma Pitagoras </p>
        </div>
        
    </div>

    </form>
</body>
</html>
