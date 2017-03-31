using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Web_Forms
{
    public partial class Resultado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string n;
                n = Convert.ToString(Request.QueryString["nombre"]);

                BonaFilmsEntities1 context = new BonaFilmsEntities1();

                var g = from c in context.Peliculas
                        join v in context.Generos on c.Genero equals v.IdGen
                        join b in context.Directores on c.Director equals b.IdDir
                        orderby c.Nombre
                        where c.Nombre.Contains(n)
                        select new { codigo = c.Id, titulo = c.Nombre, c.Año, genero = v.NombreGen, director = b.NombreDir, disponible = c.Disponibilidad, cantidad = c.Cantidad };

                GridView1.DataSource = g.ToList();
                GridView1.DataBind();
            }
        }

        protected void AgregarBoton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Agregar.aspx");
        }

        protected void Grind_modificar(object sender, EventArgs e)
        {
            LinkButton re = (LinkButton)sender;
            GridViewRow selectedRow = (GridViewRow)re.NamingContainer;
            string barcode = "?Id=" + selectedRow.Cells[2].Text;

            Response.Redirect("Modificar.aspx" + barcode);
        }

        protected void Grind_eliminar(object sender, EventArgs e)
        {
            LinkButton re = (LinkButton)sender;
            GridViewRow selectedRow = (GridViewRow)re.NamingContainer;
            var pelicula = new Pelicula { Id = Convert.ToInt32(selectedRow.Cells[2].Text) };
            BonaFilmsEntities1 context = new BonaFilmsEntities1();

            //Acá faltaría una validación que pregunte si está seguro que desea eliminar.

            context.Peliculas.Attach(pelicula);
            context.Peliculas.Remove(pelicula);
            context.SaveChanges();
            Response.Redirect(Request.RawUrl);
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            string qs = "?nombre=" + TextBox1.Text;

            Response.Redirect("/Web_Forms/Resultado.aspx" + qs);
        }
    }
}