﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login_fv.aspx.cs" Inherits="FV_login.login_fv" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <link href="Recursos/CSS/Estilo.css" rel="stylesheet" />
    <title>Login</title>
</head>
<body class="bg-light">
    <div class="wrapper">
        <div class="formcontent">
            <form id="formulario_login" runat="server">
            <div class="form-control">
                <div class="col-md-6 text-center mb-5">
                        <asp:Label class="h2" ID="lblBienvenida" runat="server" Text="Bienvenido a Feria Virtual"></asp:Label>
                </div>
                <div>
                    <asp:Label ID="lblUsuario" runat="server" Text="Correo:"></asp:Label>
                    <asp:TextBox ID="txbUsuario" CssClass="form-control" runat="server" placeholder="Correo electronico"></asp:TextBox>
                </div>
                <div>
                    <asp:label ID="lblContra" runat="server" Text="Contraseña"></asp:label>
                    <asp:TextBox ID="txbContra" CssClass="form-control" runat="server" placeholder="Contraseña"></asp:TextBox>
                </div>
                <hr />
                <div class="row">
                    <asp:Button ID="btnIngresar" CssClass="btn btn-primary btn-dark" runat="server" Text="Ingresar" />
                </div>
            </div>
        </form>
    </div>
  </div>
    
</body>
</html>
