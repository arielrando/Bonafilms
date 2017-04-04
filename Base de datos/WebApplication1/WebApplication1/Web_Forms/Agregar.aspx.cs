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

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }

        protected void agregarGenero_Click(object sender, EventArgs e)
        {
            //primero se verifica que el textbox donde va el nombre del genero
            //no este vacio, si lo esta, muestra un mensaje en un label
            if (string.IsNullOrWhiteSpace(nuevoGenero.Text))
            {
                LabelGeneroVacio.Text = "No puede agregar un Genero sin nombre ";
            }
            //si el textbox no esta vacio entonces pone el label vacio, crea una
            //nueva entidad entities, crea un nuevo objeto genero, le da el nombre
            //que esta en el textbox y finalmente el intitie lo agrega a la BDD
            else
            {
                LabelGeneroVacio.Text = "";
                /*BonaFilmsEntities1 context = new BonaFilmsEntities1();
                Genero p = new Genero();
                p.NombreGen = nuevoGenero.Text;
                context.Generos.Add(p);
                context.SaveChanges();*/
                Clases.ABMgen ambgen = new Clases.ABMgen();
                ambgen.a(nuevoGenero.Text);
                Response.Redirect(Request.RawUrl);
            }
        }

        protected void agregarDirector_Click(object sender, EventArgs e)
        {
            //primero se verifica que el textbox donde va el nombre del genero
            //no este vacio, si lo esta, muestra un mensaje en un label
            if (string.IsNullOrWhiteSpace(nuevoDirector.Text))
            {
                LabelDirectorVacio.Text = "No puede agregar un Director sin nombre ";

            }
            //si el textbox no esta vacio entonces pone el label vacio, crea una
            //nueva entidad entities, crea un nuevo objeto genero, le da el nombre
            //que esta en el textbox y finalmente el intitie lo agrega a la BDD
            else
            {
                if (string.IsNullOrWhiteSpace(nuevoDirector1.Text))
                {
                    LabelDirectorVacio.Text = "No puede agregar un Director sin apellido ";

                }
                else
                {
                    LabelDirectorVacio.Text = "";

                    /* BonaFilmsEntities1 context = new BonaFilmsEntities1();
                     Director p = new Director();
                     p.NombreDir = nuevoDirector.Text;
                     p.ApellidoDir = nuevoDirector1.Text;
                     context.Directores.Add(p);
                     context.SaveChanges();*/
                    Clases.ABMdir ambdir = new Clases.ABMdir();
                    ambdir.a(nuevoDirector.Text, nuevoDirector1.Text);
                    Response.Redirect(Request.RawUrl);
                }
            }
        }
    }
}