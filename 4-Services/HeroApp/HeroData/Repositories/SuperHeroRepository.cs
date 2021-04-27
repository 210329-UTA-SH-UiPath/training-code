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
            if (superHero != null)
            {
                context.Add(mapper.Map(superHero));
                context.SaveChanges();
            }
        }

        public void DeleteSuperHero(int id)
        {
            var superHero = GetSuperHeroById(id);
            if (superHero != null)
            {
                context.Remove(superHero);
                context.SaveChanges();
            }
        }

        public SuperHero GetSuperHeroById(int id)
        {
            var superHero = context.SuperHeroes.Where(x => x.Id == id).FirstOrDefault();
            if (superHero != null)
            {
                return mapper.Map(superHero);
            }
            else
                return null;
        }

        public SuperHero GetSuperHeroByAlias(string name)
        {
            var superHero = context.SuperHeroes.Where(x => x.Alias == name).FirstOrDefault();
            if (superHero != null)
            {
                return mapper.Map(superHero);
            }
            else
                return null;
        }

        public IEnumerable<SuperHero> GetSuperHeroes()
        {
            var superHeroes=context.SuperHeroes.Select(mapper.Map);
            return superHeroes;
        }

        public SuperHero UpdateSuperHero(SuperHero superHero)
        {
            var updateThisSuperHero = GetSuperHeroById(superHero.Id);
            if (updateThisSuperHero != null)
            {
                updateThisSuperHero.RealName = superHero.RealName;
                updateThisSuperHero.Id = superHero.Id;
                updateThisSuperHero.Alias = superHero.Alias;
                updateThisSuperHero.HideOut = superHero.HideOut;
                updateThisSuperHero.SuperPower = superHero.SuperPower;
                context.SaveChanges();
                return updateThisSuperHero;
            }
            return null;
        }
    }
}
