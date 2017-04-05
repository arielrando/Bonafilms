<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="WebApplication1.Web_Forms.Modificar" %>

<asp:Content ID="Contenido" ContentPlaceHolderID="Contenido" runat="server">

    <div class="container  text-center  texto">
        <form id="form1" runat="server">
            <div>
            </div>
            <asp:Label ID="Label1" runat="server" Text="Nombre: "></asp:Label>
            &nbsp;<br />
            <asp:TextBox ID="cambioNombre" runat="server"></asp:TextBox>

            <!-- Nombre es campo requerido !-->
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="cambioNombre" Display="Dynamic" ForeColor="#CC0000">Debe ingresar un nombre</asp:RequiredFieldValidator>

            <!-- Nombre no admite otro caracter que no sea letras o números !-->
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" Display="Dynamic" Text="El nombre introducido no debe contener caracteres especiales" ForeColor="#CC0000" ControlToValidate="cambioNombre" ValidationExpression="^[A-Z0-9 a-z]*$"></asp:RegularExpressionValidator>

            <p>
                <asp:Label ID="Label2" runat="server" Text="Año: "></asp:Label>
                &nbsp;
            </p>
            <p>
                <asp:TextBox ID="cambioAnio" runat="server"></asp:TextBox>

                <!-- Año es campo requerido !-->
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="#CC0000" Text="Debe ingresar un año" ControlToValidate="cambioAnio" Display="Dynamic"></asp:RequiredFieldValidator>

                <!-- Año debe ser numérico !-->
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="cambioAnio" Display="Dynamic" ForeColor="#CC0000" ValidationExpression="^[0-9]*$">El campo debe ser numérico</asp:RegularExpressionValidator>

                <!-- Año debe ser mayor a 1970 y menor a 2017 !-->
                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="RangeValidator" Display="Dynamic" ForeColor="#CC0000" Text="Debe introducir un año entre 1970 y 2017" ClientIDMode="Inherit" MaximumValue="2017" MinimumValue="1970" ControlToValidate="cambioAnio" Type="Integer"></asp:RangeValidator>

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
                &nbsp;
            </p>
            <p>
                <asp:TextBox ID="cambiarCantidad" runat="server"></asp:TextBox>

                <!-- Cantidad es campo requerido !-->
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="cambiarCantidad" Display="Dynamic" ForeColor="#CC0000">Debe ingresar una cantidad</asp:RequiredFieldValidator>

                <!-- Cantidad debe ser numérica !-->
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="RegularExpressionValidator" ForeColor="#CC0000" Text="El campo debe ser numérico" ControlToValidate="cambiarCantidad" Display="Dynamic" ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator>

                <!-- Cantidad no puede ser negativa ni superior a 100 !-->
                <asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage="RangeValidator" Text="Debe introducir una cantidad entre 1 y 100" ForeColor="#CC0000" Display="Dynamic" MaximumValue="100" MinimumValue="1" ControlToValidate="cambiarCantidad" Type="Integer"></asp:RangeValidator>

            </p>
            <p>

                <a href="Inicio.aspx" class="btn btn-danger">Cancelar</a>

                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" type="submit" Text="Guardar" class="btn btn-success" />
            </p>
        </form>
    </div>
</asp:Content>
