<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SISALU.Autenticacao.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>  SISALU® - Sistema de Controle de Alunos </title>
    <meta charset="utf-8" />
    <meta name="author" content="Jonas Medeiros" />
    <meta name="description" content="SISALU® - Sistema Controle de Alunos " />
    <meta name="keywords" content="SISALU, Software Educacional,CEPEP,Escola Técnica" />
    
    <!-- arquivo de formatacao da pagina -->
    <link href="../Css/sisalu.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
         <div class="header">
            <h1> SISALU® Sistema de Controle de Alunos</h1>
             <p><span class="titulo"> [ Acesso ao Sistema ] </span></p>
        </div>
    <div class="divLogin">
        <div> <img src="../Imagens/logo.png" /> </div>
        
        <asp:Label ID="lblLogin" runat="server" Text="Login de Usuário"></asp:Label>
        <asp:TextBox ID="txtLogin" runat="server" CssClass="campo"></asp:TextBox>

        <asp:Label ID="lblSenha" runat="server" Text="Senha de Acesso"></asp:Label>
        <asp:TextBox ID="txtSenha" runat="server" TextMode="Password" CssClass="campo"></asp:TextBox>

        <asp:Button ID="btnLogar" Text="Acessar" runat="server" CssClass="submit" OnClick="btnLogar_Click"/>

        <asp:Label ID="lblMensagem" runat="server" CssClass="error"></asp:Label>
         
    </div>
        <div class="rodape"> 
             <p>SISALU - Sistema de Controle de ALunos 2018 - Desenvolvido por Turma Pitagoras </p>
        </div>
    </form>
</body>
</html>
