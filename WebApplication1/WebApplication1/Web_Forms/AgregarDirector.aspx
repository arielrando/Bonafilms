<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AgregarDirector.aspx.cs" Inherits="WebApplication1.Web_Forms.AgregarDirector" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="container  text-center  texto">
        <form id="form1" runat="server">
            <div>
                <h4>Agregar un nuevo director</h4>

                Nombre y apellido:
                <asp:TextBox ID="nuevoDirector" runat="server"></asp:TextBox>
                
                <!-- El nombre del director debe ser obligatorio y debe contener únicamente letras !-->
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="nuevoDirector" Display="Dynamic" ForeColor="#CC0000">Debe introducir un nombre</asp:RequiredFieldValidator>
                
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="nuevoDirector" Display="Dynamic" ForeColor="#CC0000" ValidationExpression="^[A-Z a-z]*$">El campo debe contener solo letras</asp:RegularExpressionValidator>

                <br />
                <br />

               

                <br />
                <br />
                <a href="Agregar.aspx" class="btn btn-danger">Cancelar</a>
                <asp:Button ID="agregarDirector" runat="server" Text="Agregar" OnClick="agregarDirector_Click" class="btn btn-success" />
            </div>
        </form>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Lista" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Agregar" runat="server">
</asp:Content>
