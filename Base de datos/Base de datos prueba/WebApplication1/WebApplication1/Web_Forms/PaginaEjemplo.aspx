<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaEjemplo.aspx.cs" Inherits="WebApplication1.Web_Forms.PaginaEjemplo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>Nombre del genero</h3>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Agregar" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="LabelGeneroVacio" runat="server" Text=""></asp:Label>
        <br />
        
        <br />
       
        <br />
    </div>
    </form>
</body>
</html>
