using HeroDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroDomain.Abstraction
{
    public interface ISuperHeroRepository
    {
        IEnumerable<SuperHero> GetSuperHeroes();
        SuperHero GetSuperHeroById(int Id);
        SuperHero GetSuperHeroByName(string name);
        void AddSuperHero(SuperHero superHero);
        SuperHero UpdateSuperHero(SuperHero superHero);
        void DeleteSuperHero(int id);
    }
}
