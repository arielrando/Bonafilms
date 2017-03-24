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
            if (!IsPostBack)
            {
                BonaFilmsEntities1 context = new BonaFilmsEntities1();

                var g = from c in context.Generos
                        orderby c.NombreGen
                        select new { c.IdGen, c.NombreGen };
                DropDownList1.DataValueField = "IdGen";
                DropDownList1.DataTextField = "NombreGen";
                DropDownList1.DataSource = g.ToList();

                DataBind();
            }
           
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //primero se verifica que el textbox donde va el nombre del genero
            //no este vacio, si lo esta, muestra un mensaje en un label
            if (string.IsNullOrWhiteSpace(TextBox1.Text))
            {
                LabelGeneroVacio.Text = "No puede agregar un Genero sin nombre ";
            }
            //si el textbox no esta vacio entonces pone el label vacio, crea una
            //nueva entidad entities, crea un nuevo objeto genero, le da el nombre
            //que esta en el textbox y finalmente el intitie lo agrega a la BDD
            else
            {
                LabelGeneroVacio.Text = "";
                BonaFilmsEntities1 context = new BonaFilmsEntities1();
                Genero p = new Genero();
                p.NombreGen = TextBox1.Text;
                context.Generos.Add(p);
                context.SaveChanges();
            }
        }



        
protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = " El ID del genero es " + DropDownList1.SelectedItem.Value.ToString() + " y el nombre es " + DropDownList1.SelectedItem.Text.ToString();
        }

      
    }
}