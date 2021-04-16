using System.Collections.Generic;

namespace HeroesLib
{
  public interface IRepository
  {
    void Add(Models.SuperHero superHero);
    List<Models.SuperHero> GetAllSuperHeros();
    Models.SuperHero GetSuperHeroByName(string name);

    Models.SuperHero Update(Models.SuperHero superHeroChanges);

    void Delete(Models.SuperHero superHero);
  }
}