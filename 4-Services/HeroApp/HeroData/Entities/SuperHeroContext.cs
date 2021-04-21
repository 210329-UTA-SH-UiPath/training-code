using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroData.Entities
{
    class SuperHeroContext:DbContext
    {
        public SuperHeroContext()
        {

        }
        public SuperHeroContext(DbContextOptions<SuperHeroContext> options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:heroesapp.database.windows.net,1433;Initial Catalog=SuperHerosDb;Persist Security Info=False;User ID=dev;Password=Password123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SuperHero>().HasData(new SuperHero(-1, "Peter Parker", "Spiderman", "His study room"));
            modelBuilder.Entity<SuperHero>().HasData(new SuperHero(-2, "Thor", "Thor", "Asgard"));
        }
        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
