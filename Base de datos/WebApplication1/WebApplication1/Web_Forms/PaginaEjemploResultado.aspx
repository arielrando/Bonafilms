<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaEjemploResultado.aspx.cs" Inherits="WebApplication1.Web_Forms.PaginaEjemploResultado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <h4>ordenar la lista por</h4>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            
            <asp:ListItem Text="ID" Value="IdGen"></asp:ListItem>
            <asp:ListItem Text="Nombre" Value="NombreGen"></asp:ListItem>
        </asp:DropDownList>
    </div>
    </form>
</body>
</html>
