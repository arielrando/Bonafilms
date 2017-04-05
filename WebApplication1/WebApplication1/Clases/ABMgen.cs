using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Clases
{
    public class ABMgen
    {
        public void a(string nom)
        {
            BonaFilmsEntities1 context = new BonaFilmsEntities1();
            Genero p = new Genero();
            p.NombreGen = nom;
            context.Generos.Add(p);
            context.SaveChanges();
        }

        public void b(int id)
        {
            var genero = new Genero { IdGen = id };
            BonaFilmsEntities1 context = new BonaFilmsEntities1();
            context.Generos.Attach(genero);
            context.Generos.Remove(genero);
            context.SaveChanges();
        }

        public void m(int id, string nom)
        {
            BonaFilmsEntities1 context = new BonaFilmsEntities1();
            Genero p = context.Generos.FirstOrDefault(r => r.IdGen == id);
            p.NombreGen = nom;
            context.SaveChanges();
        }

    }
}