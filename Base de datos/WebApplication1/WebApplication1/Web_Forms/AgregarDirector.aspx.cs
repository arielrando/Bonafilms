using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Web_Forms
{
    public partial class AgregarDirector : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void agregarDirector_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                /* BonaFilmsEntities1 context = new BonaFilmsEntities1();
                     Director p = new Director();
                     p.NombreDir = nuevoDirector.Text;
                     p.ApellidoDir = nuevoDirector1.Text;
                     context.Directores.Add(p);
                     context.SaveChanges();*/
                Clases.ABMdir ambdir = new Clases.ABMdir();
                ambdir.a(nuevoDirector.Text, nuevoDirector1.Text);
                Response.Redirect("Agregar.aspx");
            }
        }
    }
}