using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nemetschek.Data.Entities;
using Nemetschek.Infrastructure.Data.Entities;

namespace Nemetschek.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<Film> Films { get; set; }

        public DbSet<Genre> Genres { get; set; }


    }
}