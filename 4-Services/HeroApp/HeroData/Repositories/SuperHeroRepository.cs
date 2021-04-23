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
            context.Add(mapper.Map(superHero));
            context.SaveChanges();
        }

        public void DeleteSuperHero(int id)
        {
            context.Remove(GetSuperHeroById(id));
            context.SaveChanges();
        }

        public SuperHero GetSuperHeroById(int id)
        {
            return mapper.Map(context.SuperHeroes.Find(id));
        }

        public SuperHero GetSuperHeroByAlias(string name)
        {
            return context.SuperHeroes.Where(s => s.Alias == name).Select(mapper.Map).FirstOrDefault();
        }

        public IEnumerable<SuperHero> GetSuperHeroes()
        {
            var superHeroes=context.SuperHeroes.Select(mapper.Map);
            return superHeroes;
        }

        public SuperHero UpdateSuperHero(SuperHero superHero)
        {
            var updateThisSuperHero = GetSuperHeroById(superHero.Id);
            updateThisSuperHero.RealName = superHero.RealName;
            updateThisSuperHero.Id = superHero.Id;
            updateThisSuperHero.Alias = superHero.Alias;
            updateThisSuperHero.HideOut = superHero.HideOut;
            updateThisSuperHero.SuperPower = superHero.SuperPower;
            context.SaveChanges();
            return updateThisSuperHero;
        }
    }
}
