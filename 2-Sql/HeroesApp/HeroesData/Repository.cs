using System.Collections.Generic;
using HeroesLib;
using HeroesLib.Models;
using System.Linq;

namespace HeroesData
{
    public class Repository : IRepository
    {
        private readonly Enities.HeroesDbContext context;
        private readonly IMapper mapper;
        public Repository(Enities.HeroesDbContext context, IMapper mapper)
        {
            this.context=context;
            this.mapper=mapper;
        }
        public void Add(SuperHero superHero)
        {
            throw new System.NotImplementedException();
        }

        public List<SuperHero> GetAllSuperHeros()
        {
           var superHeroes=context.SuperHeroes;
           return superHeroes.Select(mapper.Map).ToList();
        }

        public SuperHero GetSuperHeroByName(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}