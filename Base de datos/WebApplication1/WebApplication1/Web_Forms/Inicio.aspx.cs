using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1;

namespace Masters
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BonaFilmsEntities1 context = new BonaFilmsEntities1();

                var h = from c in context.Peliculas
                        orderby c.Nombre
                        select new { c.Id, c.Nombre, c.Año, c.Genero, c.Director, c.Disponibilidad, c.Cantidad };

                GridView1.DataSource = h.ToList();
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

        protected void Grind_eliminar (object sender, EventArgs e)
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
    }
}