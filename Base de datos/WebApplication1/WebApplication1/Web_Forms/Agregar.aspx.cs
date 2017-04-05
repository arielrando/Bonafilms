using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Web_Forms
{
    public partial class Agregar : System.Web.UI.Page
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

                DropDownListDirector.DataValueField = "IdDir";
                DropDownListDirector.DataTextField = "NombreDir";
                DropDownListDirector.DataSource = g.ToList();
                DropDownListDirector.DataBind();

                DropDownListGenero.DataValueField = "IdGen";
                DropDownListGenero.DataTextField = "NombreGen";
                DropDownListGenero.DataSource = f.ToList();
                DropDownListGenero.DataBind();
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                /*BonaFilmsEntities1 context = new BonaFilmsEntities1();
                  Pelicula p = new Pelicula();
                  p.Nombre = TextBox1.Text;
                  p.Año = Convert.ToInt32(TextBox1_1.Text);
                  p.Genero = Convert.ToInt32(DropDownListGenero.SelectedItem.Value);
                  p.Director = Convert.ToInt32(DropDownListDirector.SelectedItem.Value);
                  p.Cantidad = Convert.ToInt32(TextBox1_2.Text);
                  p.Disponibilidad = true;
                  context.Peliculas.Add(p);
                  context.SaveChanges();*/
                string nom = TextBox1.Text;
                int año = Convert.ToInt32(TextBox1_1.Text);
                int gen = Convert.ToInt32(DropDownListGenero.SelectedItem.Value);
                int dir = Convert.ToInt32(DropDownListDirector.SelectedItem.Value);
                int can = Convert.ToInt32(TextBox1_2.Text);
                Clases.ABM abm = new Clases.ABM();
                abm.a(nom, año, gen, dir, can);
                Response.Redirect("Inicio.aspx");
            }
        }
    }
}