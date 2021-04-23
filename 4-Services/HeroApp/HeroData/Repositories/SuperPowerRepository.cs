using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroDomain.Abstraction;
using HeroDomain.Models;

namespace HeroData.Repositories
{
    class SuperPowerRepository : ISuperPowerRepository
    {
        private readonly Entities.SuperHeroContext context;
        Mappers.IMapper mapper = new Mappers.Mapper();

        public SuperPowerRepository(Entities.SuperHeroContext context)
        {
            this.context = context;
        }
        public void AddSuperPower(SuperPower superPower)
        {
            context.Add(mapper.Map(superPower));
            context.SaveChanges();
        }

        public void DeleteSuperPower(int id)
        {
            var superPowerToDelete = context.SuperPowers.Find(id);
            if (superPowerToDelete != null)
            {
                context.SuperPowers.Remove(superPowerToDelete);
                context.SaveChanges();
            }
        }

        public SuperPower GetSuperPowerById(int id)
        {
            var superPower = context.SuperPowers.Where(x => x.Id == id).FirstOrDefault();
            if (superPower != null)
            {
                return mapper.Map(superPower);
            }
            else
                return null;
        }

        public IEnumerable<SuperPower> GetSuperPowers()
        {
            var superPowers = context.SuperPowers.Select(mapper.Map);
            return superPowers;
        }

        public SuperPower UpdateSuperPower(SuperPower superPower)
        {
            var superPowerToChange = GetSuperPowerById(superPower.Id);

            if (superPowerToChange != null)
            {
                superPowerToChange.Name = superPower.Name;
                superPowerToChange.Description = superPower.Description;
                superPowerToChange.OwnerId = superPower.OwnerId;
                context.Update(mapper.Map(superPowerToChange));
                context.SaveChanges();
                return superPowerToChange;
            }
            else
                return null;
        }
    }
}
