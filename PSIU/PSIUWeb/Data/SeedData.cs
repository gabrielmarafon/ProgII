using Microsoft.EntityFrameworkCore;
using PSIUWeb.Models;

namespace PSIUWeb.Data
{
    public static class SeedData
    {

        public static void EnsurePopulated(
            IApplicationBuilder app
        )
        {
            AppDbContext context =
                app.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<AppDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Patients.Any())
            {
                context.Patients.AddRange(
                    new Patient
                    {
                        Name = "Mauricio",
                        BirthDate = new DateTime(1984, 7, 5),
                        Race = Race.Pardo,
                        Height = 180,
                        Weight = 88
                    },
                    new Patient
                    {
                        Name = "Marcos",
                        BirthDate = new DateTime(1987, 2, 28),
                        Race = Race.Pardo,
                        Height = 175,
                        Weight = 90
                    }

                );

                context.SaveChanges();
            }

            if (!context.Psychologists.Any())
            {
                context.Psychologists.AddRange(
                    new Psychologist
                    {
                        Name = "Jefe",
                        CRP = "12345",
                        Specialty = "Urologista",

                    },
                    new Psychologist
                    {
                        Name = "Vitão",
                        CRP = "54321",
                        Specialty = "Ginecologista",
                    }

                );

                context.SaveChanges();
            }

        }
    }
}