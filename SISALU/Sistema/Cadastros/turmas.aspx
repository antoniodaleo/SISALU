<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="turmas.aspx.cs" Inherits="SISALU.Sistema.Cadastros.turmas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title> SISALU® - Sistema de Controle de Alunos </title>
    <link href="../../Css/sisalu.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
       
     <div>
        <div class="header">
            <h1> SISALU® Sistema de Controle de Alunos</h1>
             <p><span class="titulo"> [ Cadastro de Novas Turmas ] </span></p>
        </div>
        <div class="conteudo">
              
            <div class="painel">

                  <asp:Label ID="lblMensagem" runat="server" CssClass="error"></asp:Label>
                  <br />  <br /> 

                <div class="control">
                    <asp:Label ID="Label1" runat="server" Text="Nome da Turma"></asp:Label>
                    <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
                </div>
                 
                 <div class="control">
                    <asp:Label ID="Label8" runat="server" Text="Quant. Alunos"></asp:Label>
                    <asp:TextBox ID="txtQuantAlunos" runat="server" TextMode="Number"></asp:TextBox>
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
