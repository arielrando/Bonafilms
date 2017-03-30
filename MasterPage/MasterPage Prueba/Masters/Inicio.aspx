<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Masters.Formulario_web1" %>


<asp:Content ID="Contenido" ContentPlaceHolderID="Contenido" runat="server">
    <div class="container  text-center  texto">
  <h2>BonaFilms 2.0</h2>
  <p>Amamos las películas</p>
  <p>Por eso te ofrecemos una amplia lista de opciones para todos los gustos.</p>
</div>
   <br/>
    <br/>
 </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Lista" runat="server">
    <!-- ACA VA LA GRIDVIEW. -->
    <div class="table-responsive">
  <table class="table table-condensed table-striped table-bordered table-hover no-margin">
    <thead>
      <tr>
        <th style="width:10%">ID</th>
        <th style="width:40%">Nombre</th>
        <th style="width:20%" class="hidden-phone">Genero</th>
        <th style="width:10%" class="hidden-phone">Director</th>
        <th style="width:15%" class="hidden-phone">Stock</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td>
          <span class="name">0112</span>
        </td>
        <td class="hidden-phone">El Padrino 2</td>
        <td class="hidden-phone">
          <span class="label label label-info">Drama</span>
        </td>
        <td class="hidden-phone">X</td>
        <td class="hidden-phone">
            <asp:Label ID="Label1" runat="server" Text="Label">10</asp:Label>
        </td>
      </tr>
      <tr>
        <td>
          <span class="name">0255</span>
        </td>
        <td class="hidden-phone">La Niebla</td>
        <td class="hidden-phone">
          <span class="label label label-success">Suspenso</span>
        </td>
        <td class="hidden-phone">X</td>
        <td class="hidden-phone">
          <asp:Label ID="Label2" runat="server" Text="Label">10</asp:Label>
        </td>
      </tr>
      <tr>
        <td>
          <span class="name">6550</span>
        </td>
        <td class="hidden-phone">Buscando a Nemo</td>
        <td class="hidden-phone">
          <span class="label label label-danger">Animacion</span>
        </td>
        <td class="hidden-phone">X</td>
        <td class="hidden-phone">
         <asp:Label ID="Label3" runat="server" Text="Label">10</asp:Label>
        </td>
      </tr>
      <tr>
        <td>
          <span class="name">3002</span>
        </td>
        <td class="hidden-phone">Memento</td>
        <td class="hidden-phone">
          <span class="label label label-info">Drama</span>
        </td>
        <td class="hidden-phone">X</td>
        <td class="hidden-phone">
          <asp:Label ID="Label4" runat="server" Text="Label">10</asp:Label>
        </td>
      </tr>

    </tbody>
  </table>
</div>

<br/>
<br/>
    <form runat="server">
        <div class="form-actions">
        <asp:Button ID="AgregarBoton" runat="server" Text="Agregar" CssClass="btn btn-primary btn-lg btn-block "  Width="151px" OnClick="AgregarBoton_Click" />
    <asp:Button ID="EditarBoton" runat="server" Text="Editar" CssClass="btn btn-primary btn-lg btn-block  "  Width="151px" />
    <asp:Button ID="EliminarBoton" runat="server" Text="Eliminar" CssClass="btn btn-primary btn-lg btn-block  " Width="151px" />
    </div> 
            </form>

</asp:Content>
