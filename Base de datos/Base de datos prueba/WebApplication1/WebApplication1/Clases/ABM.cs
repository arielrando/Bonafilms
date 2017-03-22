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
    }
}