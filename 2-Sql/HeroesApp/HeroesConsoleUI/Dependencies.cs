using HeroesData;
using HeroesLib;
using Microsoft.EntityFrameworkCore;

namespace HeroesConsoleUI
{
    public static class Dependencies
    {
        public static IRepository CreateRepository(){
            var optionsBuilder=new DbContextOptionsBuilder<HeroesData.Enities.HeroesDbContext>();
            optionsBuilder.UseSqlServer("Server=tcp:heroesapp.database.windows.net,1433;Initial Catalog=HeroesDb;Persist Security Info=False;User ID=dev;Password=Password123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            var dbContext=new HeroesData.Enities.HeroesDbContext(optionsBuilder.Options);
            return new Repository(dbContext);
        }
    }
}