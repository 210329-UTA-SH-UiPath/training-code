using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroDomain.Abstraction;
using HeroDomain.Models;
using Microsoft.EntityFrameworkCore;
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
            var superHeroToDelete = context.SuperHeroes.Find(id);
            if (superHeroToDelete != null)
            {
                context.SuperHeroes.Remove(superHeroToDelete);
                context.SaveChanges();
            }
        }

        public SuperHero GetSuperHeroById(int id)
        {
            var superHero = context.SuperHeroes.Where(x => x.Id == id).Include(superHero => superHero.SuperPower).FirstOrDefault();
            if (superHero != null)
            {
                return mapper.Map(superHero);
            }
            else
                return null;
        }

        public SuperHero GetSuperHeroByName(string RealName)
        {
            var superHero = context.SuperHeroes.Where(x => x.RealName == RealName).Include(superHero => superHero.SuperPower)
                .FirstOrDefault();
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
            var superHeroToChange = GetSuperHeroById(superHero.Id);

            if (superHeroToChange != null)
            {
                superHeroToChange.RealName = superHero.RealName;
                superHeroToChange.Alias = superHero.Alias;
                superHeroToChange.HideOut = superHero.HideOut;
                superHeroToChange.SuperPower = superHero.SuperPower;
                context.Update(mapper.Map(superHeroToChange));
                context.SaveChanges();
                return superHeroToChange;
            }
            else
                return null;

        }
    }
}
