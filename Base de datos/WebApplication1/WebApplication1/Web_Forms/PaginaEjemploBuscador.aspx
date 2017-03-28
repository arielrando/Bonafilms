<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaEjemploBuscador.aspx.cs" Inherits="WebApplication1.Web_Forms.PaginaEjemploBuscador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h4>Buscar un genero</h4>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
