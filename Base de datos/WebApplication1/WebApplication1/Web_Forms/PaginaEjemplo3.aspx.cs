using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Web_Forms
{
    public partial class PaginaEjemplo3 : System.Web.UI.Page
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

                var h = from c in context.Peliculas
                        orderby c.Nombre
                        select new { c.Id, c.Nombre, c.Año, c.Genero, c.Director, c.Disponibilidad, c.Cantidad };


                DropDownListDirector.DataValueField = "IdDir";
                DropDownListDirector.DataTextField = "NombreDir";
                DropDownListDirector.DataSource = g.ToList();
                DropDownListDirector.DataBind();

                DropDownList2_1.DataValueField = "IdDir";
                DropDownList2_1.DataTextField = "NombreDir";
                DropDownList2_1.DataSource = g.ToList();
                DropDownList2_1.DataBind();

                DropDownListGenero.DataValueField = "IdGen";
                DropDownListGenero.DataTextField = "NombreGen";
                DropDownListGenero.DataSource = f.ToList();
                DropDownListGenero.DataBind();

                DropDownList2.DataValueField = "IdGen";
                DropDownList2.DataTextField = "NombreGen";
                DropDownList2.DataSource = f.ToList();
                DropDownList2.DataBind();

                DropDownList1.DataValueField = "Id";
                DropDownList1.DataTextField = "Nombre";
                DropDownList1.DataSource = h.ToList();
                DropDownList1.DataBind();

                GridView1.DataSource = h.ToList();
                GridView1.DataBind();
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //primero se verifica que el textbox donde va el nombre del genero
            //no este vacio, si lo esta, muestra un mensaje en un label
            if (string.IsNullOrWhiteSpace(TextBox1.Text))
            {
                LabelDirector1Vacio.Text = "No puede agregar una pelicula sin nombre ";

            }
            //si el textbox no esta vacio entonces pone el label vacio, crea una
            //nueva entidad entities, crea un nuevo objeto genero, le da el nombre
            //que esta en el textbox y finalmente el intitie lo agrega a la BDD
            else
            {
                if (string.IsNullOrWhiteSpace(TextBox1_1.Text))
                {
                    LabelDirector1Vacio.Text = "No puede agregar una pelicula sin año ";

                }
                else
                {
                    LabelDirector1Vacio.Text = "";

                    BonaFilmsEntities1 context = new BonaFilmsEntities1();
                    Pelicula p = new Pelicula();
                    p.Nombre = TextBox1.Text;
                    p.Año = Convert.ToInt32(TextBox1_1.Text);
                    p.Genero = Convert.ToInt32(DropDownListGenero.SelectedItem.Value);
                    p.Director = Convert.ToInt32(DropDownListDirector.SelectedItem.Value);
                    p.Cantidad = Convert.ToInt32(TextBox1_2.Text);
                    p.Disponibilidad = true;
                    context.Peliculas.Add(p);
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
            Pelicula p = context.Peliculas.FirstOrDefault(r => r.Id == n);
            Label1.Text = " El ID de la pelicula es " + p.Id.ToString() +
                ", el nombre es " + p.Nombre.ToString() + ", el año es "
                + p.Año.ToString() + ", la cantidad es " + p.Cantidad.ToString()
                + " y su disponibilidad es " + p.Disponibilidad.ToString();
            TextBox2.Text = p.Nombre.ToString();
            TextBox2_1.Text = p.Año.ToString();
            TextBox2_2.Text = p.Cantidad.ToString();
            DropDownList2.ClearSelection();
            DropDownList2.Items.FindByValue(p.Genero.ToString()).Selected = true;
            DropDownList2_1.ClearSelection();
            DropDownList2_1.Items.FindByValue(p.Director.ToString()).Selected = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(DropDownList1.SelectedItem.Value);
            BonaFilmsEntities1 context = new BonaFilmsEntities1();
            Pelicula p = context.Peliculas.FirstOrDefault(r => r.Id == n);
            context.Peliculas.Remove(p);
            context.SaveChanges();
            Response.Redirect(Request.RawUrl);

        }

        protected void Button2_1_Click(object sender, EventArgs e)
        {
            var pelicula = new Pelicula { Id = Convert.ToInt32(DropDownList1.SelectedItem.Value) };
            BonaFilmsEntities1 context = new BonaFilmsEntities1();
            context.Peliculas.Attach(pelicula);
            context.Peliculas.Remove(pelicula);
            context.SaveChanges();
            Response.Redirect(Request.RawUrl);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox2.Text))
            {
                LabelGeneroVacio2.Text = "Primero debe agregar un nuevo nombre para la pelicula";
            }
            else
            {
                int n;
                n = Convert.ToInt32(DropDownList1.SelectedItem.Value);
                BonaFilmsEntities1 context = new BonaFilmsEntities1();
                Pelicula p = context.Peliculas.FirstOrDefault(r => r.Id == n);
                p.Nombre = TextBox2.Text;
                p.Año = Convert.ToInt32(TextBox2_1.Text);
                p.Genero = Convert.ToInt32(DropDownList2.SelectedItem.Value);
                p.Director = Convert.ToInt32(DropDownList2_1.SelectedItem.Value);
                p.Cantidad = Convert.ToInt32(TextBox2_2.Text);
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
                var pelicula = new Pelicula { Id = Convert.ToInt32(DropDownList1.SelectedItem.Value) };
                BonaFilmsEntities1 context = new BonaFilmsEntities1();
                context.Peliculas.Attach(pelicula);
                pelicula.Nombre = TextBox2.Text;
                pelicula.Año = Convert.ToInt32(TextBox2_1.Text);
                pelicula.Genero = Convert.ToInt32(DropDownList2.SelectedItem.Value);
                pelicula.Director = Convert.ToInt32(DropDownList2_1.SelectedItem.Value);
                pelicula.Cantidad = Convert.ToInt32(TextBox2_2.Text);
                context.Configuration.ValidateOnSaveEnabled = false;
                context.SaveChanges();
                Response.Redirect(Request.RawUrl);
            }
        }

        protected void Grind_modificar(object sender, EventArgs e)
        {
            LinkButton re = (LinkButton)sender;
            GridViewRow selectedRow = (GridViewRow)re.NamingContainer;
            string barcode = "?Id=" + selectedRow.Cells[2].Text;

            Response.Redirect("/Web_Forms/Modificar.aspx" + barcode);
        }

        protected void Button1_1_Click(object sender, EventArgs e)
        {
            string n = TextBox1.Text;
            int a = Convert.ToInt32(TextBox1_1.Text);
            int g  = Convert.ToInt32(DropDownListGenero.SelectedItem.Value);
            int d = Convert.ToInt32(DropDownListDirector.SelectedItem.Value);
            int c = Convert.ToInt32(TextBox1_2.Text);

            Clases.ABM abm = new Clases.ABM();

            abm.a(n, a, g, d, c);
            Response.Redirect(Request.RawUrl);
        }

        protected void Button3_2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DropDownList1.SelectedItem.Value);
            string n = TextBox2.Text;
            int a = Convert.ToInt32(TextBox2_1.Text);
            int g = Convert.ToInt32(DropDownList2.SelectedItem.Value);
            int d = Convert.ToInt32(DropDownList2_1.SelectedItem.Value);
            int c = Convert.ToInt32(TextBox2_2.Text);

            Clases.ABM abm = new Clases.ABM();

            abm.m(id, n, a, g, d, c);
            Response.Redirect(Request.RawUrl);
        }

        protected void Button2_2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DropDownList1.SelectedItem.Value);
            Clases.ABM abm = new Clases.ABM();

            abm.b(id);
            Response.Redirect(Request.RawUrl);
        }
    }
}