using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Clases
{
    public class ABM
    {
        public void Subir1Pelicula()
        {
            using (BonaFilmsEntities context = new BonaFilmsEntities())
            {
                Peliculas pelicula = new Peliculas
                {
                    Nombre = "Duro de matar",
                    Año = 2001,
                    Cantidad = 10,
                    Disponibilidad = true
                };

                context.Peliculas.Add(pelicula);
                context.SaveChanges();
            }




        }

        public void SubirOtraPelicula()
        {
            using (BonaFilmsEntities context = new BonaFilmsEntities())
            {
                Peliculas pelicula = new Peliculas
                {
                    Nombre = "El rey leon",
                    Año = 1994,
                    Cantidad = 10,
                    Disponibilidad = true
                };

                context.Peliculas.Add(pelicula);
                context.SaveChanges();
            }


        }

       /* public void Mostrar1Pelicula(string n, string a, string c)
        {
            using (BonaFilmsEntities context = new BonaFilmsEntities())
            {
                Peliculas pelicula = context.Peliculas.FirstOrDefault(r => r.Nombre=="Duro de matar");


                n = " Nombre: " + pelicula.Nombre;
                a = " Año: " + pelicula.Año.ToString();
                c = " Cantidad: " + pelicula.Cantidad.ToString();

                context.SaveChanges();
            }


        }

        public void MostrarOtraPelicula(string n, string a, string c)
        {
            using (BonaFilmsEntities context = new BonaFilmsEntities())
            {
                Peliculas pelicula = context.Peliculas.FirstOrDefault(r => r.Nombre == "El rey leon");


                n = " Nombre: "+pelicula.Nombre;
                a = " Año: "+pelicula.Año.ToString();
                c = " Cantidad: "+pelicula.Cantidad.ToString();
                
                context.SaveChanges();
            }


        }*/



    }
}