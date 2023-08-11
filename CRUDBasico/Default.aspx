<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CRUDBasico.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Utilizando Asp.Net</title>
        <link href="css/style.css" rel="stylesheet" />
    </head>

    <body>
        <header> 
            <h1 runat="server" id="h1Titulo" class="center"></h1>

            <nav class="center">
                <ul>
                    <li><a href="#">Início</a></li>
                    <li><a href="#">Sobre</a></li>
                    <li><a href="#">Contato</a></li>
                </ul>
            </nav>
        </header>

       <main>
           <h2>Calculadora</h2>
           <section>
               <form id="form1" runat="server">
                   <div>
                       <p>
                            <asp:TextBox TextMode="Number" ID="txtN1" runat="server" placeholder="Número 01"></asp:TextBox>
                       </p>
                       <p>
                            <asp:TextBox ID="txtOperador" runat="server" placeholder="Operador"></asp:TextBox>
                       </p>
                       <p>

                            <asp:TextBox TextMode="Number" ID="txtN2" runat="server" placeholder="Número 02"></asp:TextBox>
                       </p>
                       <p>
                            <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click"/>
                       </p>
                       <p>
                           <label id ="lblResultado" runat="server"></label>
                       </p>
                   </div>
               </form>
           </section>
       </main>

        <footer class="center"> 
            <p>
                <label>&copy; 2023 - Todos os direitos reservados.</label>
            </p>
        </footer>
    </body>
</html>
