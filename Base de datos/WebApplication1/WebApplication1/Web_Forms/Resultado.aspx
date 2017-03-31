﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true"  CodeBehind="Resultado.aspx.cs" Inherits="WebApplication1.Web_Forms.Resultado" %>

<asp:Content ID="Contenido" ContentPlaceHolderID="Contenido" runat="server">
    <div class="container  text-center  texto">
        <h2>BonaFilms 2.0</h2>
        <p>Amamos las películas</p>
        <p>Por eso te ofrecemos una amplia lista de opciones para todos los gustos.</p>
    </div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Lista" runat="server">

   
    <div class="container  text-center  texto">
        <form runat="server">
             <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="ButtonBuscar" runat="server" Text="buscar" OnClick="ButtonBuscar_Click" />
            <div>
                <center>
                <asp:GridView ID="GridView1" runat="server">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="botonModificar" runat="server" OnClick="Grind_modificar">Modificar</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>

                                <asp:LinkButton ID="botonEliminar" runat="server" OnClick="Grind_eliminar">Eliminar</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                    </center>
            </div>
        </form>
    </div>

</asp:Content>
