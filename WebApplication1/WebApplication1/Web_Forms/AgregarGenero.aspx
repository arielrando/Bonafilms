<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AgregarGenero.aspx.cs" Inherits="WebApplication1.Web_Forms.AgregarGenero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="container  text-center  texto">
        <form id="form1" runat="server">
            <div>
                <h4>Agregar un nuevo género</h4>

                Nombre:
                <asp:TextBox ID="nuevoGenero" runat="server"></asp:TextBox>
                
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="nuevoGenero" Display="Dynamic" ForeColor="#CC0000">Debe introducir un nombre</asp:RequiredFieldValidator>

                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="nuevoGenero" Display="Dynamic" ForeColor="#CC0000" ValidationExpression="^[A-Z a-z]*$">El campo debe contener solo letras</asp:RegularExpressionValidator>

                <br />
                <br />
                <a href="Agregar.aspx" class="btn btn-danger">Cancelar</a>
                <asp:Button ID="agregarGenero" runat="server" Text="Agregar" OnClick="agregarGenero_Click" class="btn btn-success" />
            </div>
        </form>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Lista" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Agregar" runat="server">
</asp:Content>
