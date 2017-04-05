using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Clases
{
    public class ABM
    {
        public void a(string nom, int año, int gen, int dir, int can)
        {
            BonaFilmsEntities1 context = new BonaFilmsEntities1();
            Pelicula p = new Pelicula();
            p.Nombre = nom;
            p.Año = año;
            p.Genero = gen;
            p.Director = dir;
            p.Cantidad = can;
            p.Disponibilidad = true;
            p.FechaIngreso = DateTime.Now;   
            p.FechaModificacion = DateTime.Now;
            context.Peliculas.Add(p);
            context.SaveChanges();
            
        }

        public void b(int id)
        {
            var pelicula = new Pelicula { Id = id };
            BonaFilmsEntities1 context = new BonaFilmsEntities1();
            context.Peliculas.Attach(pelicula);
            context.Peliculas.Remove(pelicula);
            context.SaveChanges();
            
        }

        public void m(int id, string nom, int año, int gen, int dir, int can)
        {
            BonaFilmsEntities1 context = new BonaFilmsEntities1();
            Pelicula p = context.Peliculas.FirstOrDefault(r => r.Id == id);
            p.Nombre = nom;
            p.Año = año;
            p.Genero = gen;
            p.Director = dir;
            p.Cantidad = can;
            p.FechaModificacion = DateTime.Now;
            context.SaveChanges();    
        }

    }
}