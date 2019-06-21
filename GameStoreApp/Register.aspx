<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="GameStoreApp.Register" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Sklep - Game Store</title>
    <link href="/Content/bootstrap.css" rel="stylesheet"/>
<link href="/Content/site.css" rel="stylesheet"/>

    <script src="/Scripts/modernizr-2.8.3.js"></script>

</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="/">Game Store</a>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li><a href="/Store">Sklep</a></li>
                    <%if (User.Identity.IsAuthenticated)
                        {%>
                    <li><a href="/Login.aspx"> Wyloguj</a></li>
                    <%} else { %>
                    <li><a href="/Login.aspx"> Zaloguj</a></li>
                    <%} %>
                </ul>
            </div>
        </div>
    </div>
    <div class="container body-content">
    <form id="form1" runat="server">
    <div>
        <br />
        <h3 style="font-size: medium">Zarejestruj nowego użytkownika</h3>
        <hr />
        <p>
            <asp:Literal runat="server" ID="StatusMessage" />
        </p>                
        <div style="margin-bottom:10px">
            <asp:Label runat="server" AssociatedControlID="UserName">Nazwa użytkownika</asp:Label>
            <div>
                <asp:TextBox runat="server" ID="UserName" />                
            </div>
        </div>
        <div style="margin-bottom:10px">
            <asp:Label runat="server" AssociatedControlID="Password">Hasło</asp:Label>
            <div>
                <asp:TextBox runat="server" ID="Password" TextMode="Password" />                
            </div>
        </div>
        <div style="margin-bottom:10px">
            <asp:Label runat="server" AssociatedControlID="ConfirmPassword">Potwierdź hasło</asp:Label>
            <div>
                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" />                
            </div>
        </div>
        <div>
            <div>
                <asp:Button runat="server" OnClick="CreateUser_Click" Text="Zarejestruj się" />
            </div>
        </div>
    </div>
    </form>
         <hr />
        <footer>
            <p>&copy; 2019 - Game Store</p>
        </footer>
    </div>

    <script src="/Scripts/jquery-3.3.1.js"></script>

    <script src="/Scripts/bootstrap.js"></script>

    
</body>
</html>
