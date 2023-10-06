using PSIUWeb.Data.Interface;
using PSIUWeb.Models;

namespace PSIUWeb.Data.Ef
{     public class EfPsychologistRepository : IPsychologistRepository
    {
        private AppDbContext context;

        public EfPsychologistRepository(AppDbContext ctx)
        {
            context = ctx;
        }

        public Psychologist? Create(Psychologist g)
        {
            try
            {
                context.Psychologists?.Add(g);
                context.SaveChanges();
            }
            catch
            {
                return null;
            }
            return g;
        }

        public Psychologist? Delete(int id)
        {
            Psychologist? g = GetPsychologistById(id);

            if (g == null)
                return null;

            context.Psychologists?.Remove(g);
            context.SaveChanges();
            return g;

         }

        public Psychologist? GetPsychologistById(int id)
        {
            Psychologist? g = context.Psychologists?.Where(g => g.Id == id).FirstOrDefault();
            return g;   
        }

        public IQueryable<Psychologist>? GetPsychologists()
        {
            return context.Psychologists;
        }

        public Psychologist? Update(Psychologist g)
        {
            try
            {
                context.Psychologists?.Update(g);
                context.SaveChanges();
            }
            catch
            {
                return null;
            }
            return g;
        }
    }
}
