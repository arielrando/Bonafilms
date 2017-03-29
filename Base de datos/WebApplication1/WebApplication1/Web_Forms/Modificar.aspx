<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="WebApplication1.Web_Forms.Modificar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Nombre: "></asp:Label>
&nbsp;<br />
        <asp:TextBox ID="cambioNombre" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Año: "></asp:Label>
&nbsp;</p>
        <p>
            <asp:TextBox ID="cambioAnio" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Director: "></asp:Label>
&nbsp;<br />
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        &nbsp;<br />
        <asp:Label ID="Label4" runat="server" Text="Género: "></asp:Label>
&nbsp;<br />
        <asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Cantidad: "></asp:Label>
&nbsp;</p>
        <p>
            <asp:TextBox ID="cambiarCantidad" runat="server"></asp:TextBox>
        </p>
        <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
    </form>
</body>
</html>
