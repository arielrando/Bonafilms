<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="Masters.Formulario_web12" %>
<asp:Content ID="Content2" ContentPlaceHolderID="Lista" runat="server">
    <br/>
    <br/>
    <br/>
    <br/>
    <form runat="server">
    <div class="table-responsive">
  <table class="table table-condensed table-striped table-bordered table-hover no-margin">
    <thead>
      <tr>
        <th style="width:10%">ID</th>
        <th style="width:40%">Nombre</th>
        <th style="width:20%" class="hidden-phone">Genero</th>
        <th style="width:10%" class="hidden-phone">Director</th>
        <th style="width:15%" class="hidden-phone">Stock</th>
          <th style="width:40px" class="hidden-phone">Opciones</th>
          
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
          <td><asp:Button ID="btnDelete" runat="server" Text="Quitar" CssClass="btn btn-danger" CommandName="Delete" OnClientClick="return confirm('¿Eliminar cliente?');" />
                    <asp:Button ID="btnEdit" runat="server" Text="Editar" CssClass="btn btn-info" CommandName="Edit" /></td>
     
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
           <td><asp:Button ID="Button1" runat="server" Text="Quitar" CssClass="btn btn-danger" CommandName="Delete" OnClientClick="return confirm('¿Eliminar cliente?');" />
                    <asp:Button ID="Button2" runat="server" Text="Editar" CssClass="btn btn-info" CommandName="Edit" /></td>
     
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
           <td><asp:Button ID="Button3" runat="server" Text="Quitar" CssClass="btn btn-danger" CommandName="Delete" OnClientClick="return confirm('¿Eliminar cliente?');" />
                    <asp:Button ID="Button4" runat="server" Text="Editar" CssClass="btn btn-info" CommandName="Edit" /></td>
     
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
           <td><asp:Button ID="Button5" runat="server" Text="Quitar" CssClass="btn btn-danger" CommandName="Delete" OnClientClick="return confirm('¿Eliminar cliente?');" />
                    <asp:Button ID="Button6" runat="server" Text="Editar" CssClass="btn btn-info" CommandName="Edit" /></td>
     
      </tr>

    </tbody>
  </table>
</div>
</form>
<br/>
<br/>
</asp:Content>
