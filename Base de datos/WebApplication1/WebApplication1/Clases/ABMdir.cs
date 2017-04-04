using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Clases
{
    public class ABMdir
    {
        public void a(string nom, string ape)
        {
            BonaFilmsEntities1 context = new BonaFilmsEntities1();
            Director p = new Director();
            p.NombreDir = nom;
            p.ApellidoDir = ape;
            context.Directores.Add(p);
            context.SaveChanges();
        }

        public void b(int id)
        {
            var director = new Director { IdDir = id };
            BonaFilmsEntities1 context = new BonaFilmsEntities1();
            context.Directores.Attach(director);
            context.Directores.Remove(director);
            context.SaveChanges();
        }

        public void m(int id, string nom, string ape)
        {
            BonaFilmsEntities1 context = new BonaFilmsEntities1();
            Director p = context.Directores.FirstOrDefault(r => r.IdDir == id);
            p.NombreDir = nom;
            p.ApellidoDir = ape;
            context.SaveChanges();
        }

    }
}