using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Web_Forms
{
    public partial class PaginaEjemplo2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BonaFilmsEntities1 context = new BonaFilmsEntities1();

                var g = from c in context.Directores
                        orderby c.NombreDir
                        select new { c.IdDir, c.NombreDir };
                

                DropDownList1.DataValueField = "IdDir";
                DropDownList1.DataTextField = "NombreDir";
                DropDownList1.DataSource = g.ToList();
                DropDownList1.DataBind();

                GridView1.DataSource = g.ToList();
                GridView1.DataBind();
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //primero se verifica que el textbox donde va el nombre del genero
            //no este vacio, si lo esta, muestra un mensaje en un label
            if (string.IsNullOrWhiteSpace(TextBox1.Text))
            {
                LabelDirector1Vacio.Text = "No puede agregar un Director sin nombre ";
                
            }
            //si el textbox no esta vacio entonces pone el label vacio, crea una
            //nueva entidad entities, crea un nuevo objeto genero, le da el nombre
            //que esta en el textbox y finalmente el intitie lo agrega a la BDD
            else
            {
                if (string.IsNullOrWhiteSpace(TextBox1_1.Text))
                {
                    LabelDirector1Vacio.Text = "No puede agregar un Director sin apellido ";
                    
                }
                else
                {
                    LabelDirector1Vacio.Text = "";
                    
                    BonaFilmsEntities1 context = new BonaFilmsEntities1();
                    Director p = new Director();
                    p.NombreDir = TextBox1.Text;
                    p.ApellidoDir = TextBox1_1.Text;
                    context.Directores.Add(p);
                    context.SaveChanges();
                    Response.Redirect(Request.RawUrl);
                }
            }
        }




        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(DropDownList1.SelectedItem.Value);
            BonaFilmsEntities1 context = new BonaFilmsEntities1();
            Director p = context.Directores.FirstOrDefault(r => r.IdDir == n);
            Label1.Text = " El ID del director es " + p.IdDir.ToString() + ", el nombre es " + p.NombreDir.ToString() + " y el apellido es " + p.ApellidoDir.ToString();
            TextBox2.Text = p.NombreDir.ToString();
            TextBox2_1.Text = p.ApellidoDir.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(DropDownList1.SelectedItem.Value);
            BonaFilmsEntities1 context = new BonaFilmsEntities1();
            Director p = context.Directores.FirstOrDefault(r => r.IdDir == n);
            context.Directores.Remove(p);
            context.SaveChanges();
            Response.Redirect(Request.RawUrl);

        }

        protected void Button2_1_Click(object sender, EventArgs e)
        {
            var director = new Director { IdDir = Convert.ToInt32(DropDownList1.SelectedItem.Value) };
            BonaFilmsEntities1 context = new BonaFilmsEntities1();
            context.Directores.Attach(director);
            context.Directores.Remove(director);
            context.SaveChanges();
            Response.Redirect(Request.RawUrl);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox2.Text))
            {
                LabelGeneroVacio2.Text = "Primero debe agregar el nuevo Director";
            }
            else
            {
                int n;
                n = Convert.ToInt32(DropDownList1.SelectedItem.Value);
                BonaFilmsEntities1 context = new BonaFilmsEntities1();
                Director p = context.Directores.FirstOrDefault(r => r.IdDir == n);
                p.NombreDir = TextBox2.Text;
                p.ApellidoDir = TextBox2_1.Text;
                context.SaveChanges();
                Response.Redirect(Request.RawUrl);
            }
        }

        protected void Button3_1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox2.Text))
            {
                LabelGeneroVacio2.Text = "Primero debe agregar el nuevo Director";
            }
            else
            {
                var director = new Director { IdDir = Convert.ToInt32(DropDownList1.SelectedItem.Value) };
                BonaFilmsEntities1 context = new BonaFilmsEntities1();
                context.Directores.Attach(director);
                director.NombreDir = TextBox2.Text;
                director.ApellidoDir = TextBox2_1.Text;
                context.Configuration.ValidateOnSaveEnabled = false;
                context.SaveChanges();
                Response.Redirect(Request.RawUrl);
            }
        }
    }
}