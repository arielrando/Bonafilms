using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Web_Forms
{
    public partial class PaginaEjemplo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Clases.ABM p = new Clases.ABM();

            p.Subir1Pelicula();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Clases.ABM p = new Clases.ABM();

            p.SubirOtraPelicula();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            using (BonaFilmsEntities context = new BonaFilmsEntities())
            {
                Peliculas pelicula = context.Peliculas.FirstOrDefault(r => r.Nombre == "Duro de matar");
                Label1_1.Text = pelicula.Nombre;
                Label1_2.Text = pelicula.Año.ToString();
                Label1_3.Text = pelicula.Cantidad.ToString();
            }


        }

        protected void Button4_Click(object sender, EventArgs e)
        {
           

            using (BonaFilmsEntities context = new BonaFilmsEntities())
            {
                Peliculas pelicula = context.Peliculas.FirstOrDefault(r => r.Nombre == "El rey leon");
                Label2_1.Text = pelicula.Nombre;
                Label2_2.Text = pelicula.Año.ToString();
                Label2_3.Text = pelicula.Cantidad.ToString();
            }

            
        }
    }
}