using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PjGabrielMarafon.Models;

namespace PjGabrielMarafon.Data
{
    public class AppDbContext :
        IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Psico>? Psicos { get; set; }

    }
}