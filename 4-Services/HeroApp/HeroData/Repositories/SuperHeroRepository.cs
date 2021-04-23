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
            throw new NotImplementedException();
        }

        public void DeleteSuperHero(int id)
        {
            throw new NotImplementedException();
        }

        public SuperHero GetSuperHeroById()
        {
            throw new NotImplementedException();
        }

        public SuperHero GetSuperHeroByName()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SuperHero> GetSuperHeroes()
        {
            var superHeroes = context.SuperHeroes.Select(mapper.Map);
            return superHeroes;
        }

        public SuperHero UpdateSuperHero(SuperHero superHero)
        {
            throw new NotImplementedException();
        }
    }
}
