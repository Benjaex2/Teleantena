<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TeleAntena.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" />
    <link type="text/css" rel="stylesheet" href="css/materialize.min.css"  media="screen,projection"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-bottom: 0;
        }
    </style>
</head>
<body>
    <center>
        <img class="responsive-img" style="width: 250px;" src="/Img/logo.png" />
      <div class="section"></div>

      <h5 class="indigo-text">Inicie sesión para continuar</h5>
      <div class="section"></div>
        <div class="container">
            <div class="z-depth-1 grey lighten-4 row" style="display: inline-block; padding: 32px 48px 0px 48px; border: 1px solid #EEE;">
                <form class="col s12" method="post" runat="server">
                    <div class='row'>
                        <div class='input-field col s12'>
                            <asp:TextBox ID="TxtUser" class="validate" runat="server"></asp:TextBox>
                            <asp:Label id="label1" AssociatedControlId="TxtUser" Text="Ingrese su nombre de usuario" runat="server" />
                        </div>
                        <div class="col">
                            <asp:RequiredFieldValidator ID="ValidadorUser" ControlToValidate="TxtUser" runat="server" ForeColor="Red" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class='row'>
                        <div class='input-field col s12'>
                            <asp:TextBox ID="TxtContra" CssClass="validate" TextMode="Password" runat="server"></asp:TextBox>
                            <asp:Label id="label" AssociatedControlId="TxtContra" Text="Ingrese su contraseña" runat="server" />
                        </div>
                        <div class="col">
                            <asp:RequiredFieldValidator ID="ValidadorContra" ControlToValidate="TxtContra" runat="server" ForeColor="Red" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class='row'>
                        <asp:Button ID="BtnLogin" runat="server" class='col s12 btn-large waves-effect indigo' Text="Ingresar" OnClick="BtnLogin_Click" />
                    </div>  
                    <div class="row">
                        <asp:Label ID="LbMensaje" runat="server" Text=""></asp:Label>
                    </div>
                </form>
            </div>
        </div>
    </center>    

    <script type="text/javascript" src="js/materialize.min.js"></script>

</body>
</html>