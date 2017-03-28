using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Web_Forms
{
    public partial class PaginaEjemploResultado : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               string n;
               n = Convert.ToString(Request.QueryString["nombre"]);

                BonaFilmsEntities1 context = new BonaFilmsEntities1();

                var g = from c in context.Generos
                        orderby c.NombreGen
                        where c.NombreGen.Contains(n)
                        select new { c.IdGen, c.NombreGen };

                

                GridView1.DataSource = g.ToList();
                GridView1.DataBind();

                Label1.Text = n;
            }
        }

        protected void jo()
        {

            string n;
            n = Convert.ToString(Request.QueryString["nombre"]);
            var m = "c." + Convert.ToString(DropDownList1.SelectedValue);

            BonaFilmsEntities1 context = new BonaFilmsEntities1();

            var g = from c in context.Generos
                    orderby c.NombreGen
                    where c.NombreGen.Contains(n)

                    select new { c.IdGen, c.NombreGen };

            GridView1.DataSource = g.ToList();
            GridView1.DataBind();

            Label1.Text = m;

        }

        protected void ju()
        {

            string n;
            n = Convert.ToString(Request.QueryString["nombre"]);
            var m = "c." + Convert.ToString(DropDownList1.SelectedValue);

            BonaFilmsEntities1 context = new BonaFilmsEntities1();

            var g = from c in context.Generos
                    orderby c.IdGen
                    where c.NombreGen.Contains(n)

                    select new { c.IdGen, c.NombreGen };

            GridView1.DataSource = g.ToList();
            GridView1.DataBind();

            Label1.Text = m;

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string k = DropDownList1.SelectedItem.Text;

            switch (k)
            {
                case "ID":
                    ju();
                    break;
                case "Nombre":
                    jo();
                    break;
                        
            }
        }
    }
}