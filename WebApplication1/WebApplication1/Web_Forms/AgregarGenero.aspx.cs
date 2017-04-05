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
                Clases.ABMgen ambgen = new Clases.ABMgen();
                ambgen.a(nuevoGenero.Text);
                Response.Redirect("Agregar.aspx");
            }
        }
    }
}