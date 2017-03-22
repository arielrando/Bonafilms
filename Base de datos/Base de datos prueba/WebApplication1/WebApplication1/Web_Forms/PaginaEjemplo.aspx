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
        <asp:Button ID="Button1" runat="server" Text="Agregar una pelicula" OnClick="Button1_Click" />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Agregar otra pelicula" OnClick="Button2_Click" />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Mostrar una pelicula" OnClick="Button3_Click" />
        <asp:Label ID="Label1_1" runat="server" Text=""></asp:Label>
        <asp:Label ID="Label1_2" runat="server" Text=""></asp:Label>
        <asp:Label ID="Label1_3" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="Button4" runat="server" Text="Mostrar otra pelicula" OnClick="Button4_Click" /> 
        <asp:Label ID="Label2_1" runat="server" Text=""></asp:Label> 
        <asp:Label ID="Label2_2" runat="server" Text=""></asp:Label> 
        <asp:Label ID="Label2_3" runat="server" Text=""></asp:Label>
        <br />
    </div>
    </form>
</body>
</html>
