using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroDomain.Abstraction;
using HeroDomain.Models;

namespace HeroData.Repositories
{
    public class SuperHeroRepository : ISuperHeroRepository
    {
        private readonly Entities.SuperHeroContext context;
        Mappers.IMapper mapper = new Mappers.Mapper();
        public SuperHeroRepository(Entities.SuperHeroContext context)
        {
            this.context = context;
        }
        public void AddSuperHero(SuperHero superHero)
        {
            context.SuperHeroes.Add(mapper.Map(superHero));
            context.SaveChanges();
        }

        public void DeleteSuperHero(int id)
        {
            var hero = context.SuperHeroes.FirstOrDefault(hero => hero.Id == id);
            context.SuperHeroes.Remove(hero);
            context.SaveChanges();
        }

        public SuperHero GetSuperHeroById(int id)
        {
            var hero = context.SuperHeroes.Where(hero => hero.id == id).FirstOrDefault();
            return mapper.Map(hero);
        }

        public SuperHero GetSuperHeroByName(string name)
        {
            var hero = context.SuperHeroes.Where(hero => hero.RealName == name).FirstOrDefault();
            if (hero is not null)
                return mapper.Map(hero);
        }

        public IEnumerable<SuperHero> GetSuperHeroes()
        {
            var superHeroes=context.SuperHeroes.Select(mapper.Map);
            return superHeroes;
        }

        public SuperHero UpdateSuperHero(SuperHero superHero)
        {
            var superHeroChanges = context.SuperHeroes.Where(x => x.Id == superHero.Id).FirstOrDefault();
            if (superHero != null)
            {
                superHero.Alias = superHeroChanges.Alias;
                superHero.HideOut = superHeroChanges.HideOut;
                context.Update(superHero);
                context.SaveChanges();
                return superHero;
            }
            return mapper.Map(superHeroChanges);
        }
    }
}
