<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="WebApplication1.Web_Forms.Agregar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="container  text-center  texto">
        <form id="form1" runat="server">
            <div>
                <h5>Nombre: </h5> <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <h5>Año: </h5>
                <asp:TextBox ID="TextBox1_1" runat="server"></asp:TextBox>
                <br />
                <h5>Genero: </h5>
                <asp:DropDownList ID="DropDownListGenero" runat="server"></asp:DropDownList>
                <h5>Nuevo género: </h5> 
                Nombre: <asp:TextBox ID="nuevoGenero" runat="server"></asp:TextBox> <asp:Button ID="agregarGenero" runat="server" Text="Agregar" OnClick="agregarGenero_Click" class="btn btn-success" />
                <asp:Label ID="LabelGeneroVacio" runat="server" Text=""></asp:Label>
                <br />
                <h5>Director: </h5>
                <asp:DropDownList ID="DropDownListDirector" runat="server"></asp:DropDownList>
                <h5>Nuevo director: </h5> 
                
                Nombre: <asp:TextBox ID="nuevoDirector" runat="server"></asp:TextBox>
                Apellido: <asp:TextBox ID="nuevoDirector1" runat="server"></asp:TextBox>

                <asp:Button ID="agregarDirector" runat="server" Text="Agregar" OnClick="agregarDirector_Click" class="btn btn-success" />
                
                <asp:Label ID="LabelDirectorVacio" runat="server" Text=""></asp:Label>
                <br />
                <h5>Cantidad: </h5>
                <asp:TextBox ID="TextBox1_2" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button2" runat="server" Text="Cancelar" class="btn btn-danger" OnClick="Button2_Click" />
                <asp:Button ID="Button1" runat="server" Text="Agregar" OnClick="Button1_Click" class="btn btn-success" />
                <br />
                <asp:Label ID="LabelDirector1Vacio" runat="server" Text=""></asp:Label>
            </div>
        </form>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Lista" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Agregar" runat="server">
</asp:Content>
