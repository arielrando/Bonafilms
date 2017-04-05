using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Web_Forms
{
    public partial class AgregarGenero : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void agregarGenero_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                /*BonaFilmsEntities1 context = new BonaFilmsEntities1();
                Genero p = new Genero();
                p.NombreGen = nuevoGenero.Text;
                context.Generos.Add(p);
                context.SaveChanges();*/
                Clases.ABMgen ambgen = new Clases.ABMgen();
                ambgen.a(nuevoGenero.Text);
                Response.Redirect("Agregar.aspx");
            }
        }
    }
}