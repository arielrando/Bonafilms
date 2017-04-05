<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="WebApplication1.Web_Forms.Agregar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="container  text-center  texto">
        <form id="form1" runat="server">
            <div>
                Nombre:
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <!-- Nombre es campo requerido !-->
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox1" Display="Dynamic" ForeColor="#CC0000">Debe ingresar un nombre</asp:RequiredFieldValidator>

                <!-- Nombre no admite otro caracter que no sea letras o números !-->
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" Display="Dynamic" Text="El nombre introducido no debe contener caracteres especiales" ForeColor="#CC0000" ControlToValidate="Textbox1" ValidationExpression="^[A-Z0-9 a-z]*$"></asp:RegularExpressionValidator>

                <br />
                <br />

                Año:
                <asp:TextBox ID="TextBox1_1" runat="server"></asp:TextBox>

                <!-- Año es campo requerido !-->
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="#CC0000" Text="Debe ingresar un año" ControlToValidate="TextBox1_1" Display="Dynamic"></asp:RequiredFieldValidator>

                <!-- Año debe ser numérico !-->
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox1_1" Display="Dynamic" ForeColor="#CC0000" ValidationExpression="^[0-9]*$">El campo debe ser numérico</asp:RegularExpressionValidator>

                <!-- Año debe ser mayor a 1970 y menor a 2017 !-->
                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="RangeValidator" Display="Dynamic" ForeColor="#CC0000" Text="Debe introducir un año entre 1970 y 2017" ClientIDMode="Inherit" MaximumValue="2017" MinimumValue="1970" ControlToValidate="TextBox1_1"></asp:RangeValidator>

                <br />
                <br />
                Elija un género:
                <asp:DropDownList ID="DropDownListGenero" runat="server"></asp:DropDownList>

                <a href="AgregarGenero.aspx">ó agregue uno nuevo</a>


                <br />
                <br />
                Elija un director:
                <asp:DropDownList ID="DropDownListDirector" runat="server"></asp:DropDownList>

                <a href="AgregarDirector.aspx">ó agregue uno nuevo</a>

                <br />
                <br />
                Cantidad:
                <asp:TextBox ID="TextBox1_2" runat="server"></asp:TextBox>

                <!-- Cantidad es campo requerido !-->
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox1_2" Display="Dynamic" ForeColor="#CC0000">Debe ingresar una cantidad</asp:RequiredFieldValidator>

                <!-- Cantidad debe ser numérica !-->
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="RegularExpressionValidator" ForeColor="#CC0000" Text="El campo debe ser numérico" ControlToValidate="TextBox1_2" Display="Dynamic" ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator>

                <!-- Cantidad no puede ser negativa ni superior a 100 !-->
                <asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage="RangeValidator" Text="Debe introducir una cantidad entre 0 y 100" ForeColor="#CC0000" Display="Dynamic" MaximumValue="100" MinimumValue="0" ControlToValidate="TextBox1_2"></asp:RangeValidator>


                <br />
                <br />
                <a href="Inicio.aspx" class="btn btn-danger">Cancelar</a>
                <asp:Button ID="Button1" runat="server" Text="Agregar" OnClick="Button1_Click" class="btn btn-success" />
            </div>
        </form>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Lista" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Agregar" runat="server">
</asp:Content>
