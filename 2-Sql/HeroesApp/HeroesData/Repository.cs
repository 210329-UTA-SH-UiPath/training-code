using System.Collections.Generic;
using HeroesLib;
using HeroesLib.Models;
using System.Linq;

namespace HeroesData
{
  public class Repository : IRepository
  {
    private readonly Enities.HeroesDbContext context;
    IMapper mapper = new Mapper();
    public Repository(Enities.HeroesDbContext context)
    {
      this.context = context;
    }
    public void Add(SuperHero superHero)
    {
      context.Add(mapper.Map(superHero));
      context.SaveChanges();
    }

    public void Delete(SuperHero superHero)
    {

      var herotobedeleted = context.SuperHeroes.Where(x => x.Id == superHero.Id).FirstOrDefault();
      if (herotobedeleted != null)
      {
        context.SuperHeroes.Remove(herotobedeleted);
        context.SaveChanges();
      }

    }

    public List<SuperHero> GetAllSuperHeros()
    {
      var superHeroes = context.SuperHeroes;
      return superHeroes.Select(mapper.Map).ToList();
    }

    public SuperHero GetSuperHeroByName(string name)
    {
      var superHero = context.SuperHeroes.Where(x => x.Alias == name).FirstOrDefault();
      return mapper.Map(superHero);
    }

    public SuperHero Update(SuperHero superHeroChanges)
    {
      var superHero = context.SuperHeroes.Where(x => x.Id == superHeroChanges.Id).FirstOrDefault();
      if (superHero != null)
      {
        superHero.Alias = superHeroChanges.Alias;
        superHero.HideOut = superHeroChanges.HideOut;
        context.Update(superHero);
        context.SaveChanges();
        return superHeroChanges;
      }

      return mapper.Map(superHero);

    }
  }
}