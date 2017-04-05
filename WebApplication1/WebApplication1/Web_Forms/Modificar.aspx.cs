using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Web_Forms
{
    public partial class Modificar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BonaFilmsEntities1 context = new BonaFilmsEntities1();

                var g = from c in context.Directores
                        orderby c.NombreDir
                        select new { c.IdDir, c.NombreDir };

                var f = from c in context.Generos
                        orderby c.NombreGen
                        select new { c.IdGen, c.NombreGen };

                DropDownList1.DataValueField = "IdDir";
                DropDownList1.DataTextField = "NombreDir";
                DropDownList1.DataSource = g.ToList();
                DropDownList1.DataBind();

                DropDownList2.DataValueField = "IdGen";
                DropDownList2.DataTextField = "NombreGen";
                DropDownList2.DataSource = f.ToList();
                DropDownList2.DataBind();

                int n;
                n = Convert.ToInt32(Request.QueryString["Id"]);

                Pelicula p = context.Peliculas.FirstOrDefault(r => r.Id == n);
                cambioNombre.Text = p.Nombre;
                cambioAnio.Text = Convert.ToString(p.Año);
                DropDownList2.SelectedItem.Value = Convert.ToString(p.Genero);
                DropDownList1.SelectedItem.Value = Convert.ToString(p.Director);
                cambiarCantidad.Text = Convert.ToString(p.Cantidad);
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {


            int n;
            n = Convert.ToInt32(Request.QueryString["Id"]);

            if (IsValid)
            {
                string nom = cambioNombre.Text;
                int año = Convert.ToInt32(cambioAnio.Text);
                int gen = Convert.ToInt32(DropDownList2.SelectedItem.Value);
                int dir = Convert.ToInt32(DropDownList1.SelectedItem.Value);
                int can = Convert.ToInt32(cambiarCantidad.Text);
                Clases.ABM amb = new Clases.ABM();
                amb.m(n, nom, año, gen, dir, can);
                Response.Redirect("Inicio.aspx");
            }
        }
    }
}