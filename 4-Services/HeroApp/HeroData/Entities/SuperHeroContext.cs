using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HeroData.Entities
{
    public class SuperHeroContext:DbContext
    {
        public SuperHeroContext()
        {
            
        }
        public SuperHeroContext(DbContextOptions options):base(options)
        {

        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SuperHero>().HasData(new SuperHero(1, "Peter Parker", "Spiderman", "His study room"));
            modelBuilder.Entity<SuperHero>().HasData(new SuperHero(2, "Thor", "Thor", "Asgard"));

            modelBuilder.Entity<SuperPower>().HasData(new SuperPower(1, "spider abilities", "Can climb any building and throw web at the enemy", 1));
            modelBuilder.Entity<SuperPower>().HasData(new SuperPower(2, "Magical hammer", "It can kill any enemy and open Asgard gates", 2));
        }
        public DbSet<SuperHero> SuperHeroes { get; set; }
        public DbSet<SuperPower> SuperPowers { get; set; }
    }
}
