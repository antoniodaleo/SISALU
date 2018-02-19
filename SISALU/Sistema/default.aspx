<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="SISALU.Sistema._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SISALU® - Sistema de Controle de Alunos </title>
    <link href="../Css/sisalu.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="header">
            <h1> SISALU® Sistema de Controle de Alunos</h1>
             <p><span class="titulo"> [ Painel Administrativo ] </span></p>
        </div>
        <div class="conteudo">
            <asp:Button runat="server" Text="Sair do Sistema" ID="btnSair"/>  
            
            <div class="menu">
                        <figure>
                             <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Sistema/Cadastros/alunos.aspx">  
                                 <img src="../Imagens/she_user.png" />
                             </asp:HyperLink>
                            <figcaption>
                                <h2>Cadastrar Aluno</h2>
                            </figcaption>
                        </figure> 

                   
                          <figure>
                             <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="#">  
                                 <img src="../Imagens/search.png" />
                             </asp:HyperLink>
                            <figcaption>
                                <h2>Consultar Aluno</h2>
                            </figcaption>
                        </figure> 

                  
                         <figure>
                             <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Sistema/Cadastros/matricula.aspx">  
                                 <img src="../Imagens/application.png" />
                             </asp:HyperLink>
                            <figcaption>
                                <h2>Realizar Matricula</h2>
                            </figcaption>
                        </figure> 

                   
                        <figure>
                             <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="#">  
                                 <img src="../Imagens/archive.png" />
                             </asp:HyperLink>
                            <figcaption>
                                <h2>Consultar Turmas </h2>
                            </figcaption>
                        </figure>


                        <figure>
                             <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="#">  
                                 <img src="../Imagens/printer.png" />
                             </asp:HyperLink>
                            <figcaption>
                                <h2>Relatorio Matricula </h2>
                            </figcaption>
                        </figure>

                    
                        <figure>
                             <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="#">  
                                 <img src="../Imagens/calculator.png" />
                             </asp:HyperLink>
                            <figcaption>
                                <h2>Consultar Boletos </h2>
                            </figcaption>
                        </figure>

                    
<figure>
                             <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="#">  
                                 <img src="../Imagens/users.png" />
                             </asp:HyperLink>
                            <figcaption>
                                <h2>Controle Usuários </h2>
                            </figcaption>
                        </figure>

                  
            </div>
        </div>
        <div class="rodape"> 

        </div>
        
    </div>
    </form>
</body>
</html>
