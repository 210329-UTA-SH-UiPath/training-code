using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroDomain.Abstraction;
using HeroDomain.Models;

namespace HeroData.Repositories
{
    public class SuperPowerRepository : ISuperPowerRepository
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
            context.Remove(GetSuperPowerById(id));
            context.SaveChanges();
        }

        public SuperPower GetSuperPowerById(int id)
        {
            return mapper.Map(context.SuperPowers.Find(id));
        }

        public SuperPower GetSuperPowerByName(String name)
        {
            return context.SuperPowers.Where(s => s.Name == name).Select(mapper.Map).FirstOrDefault();
        }

        public IEnumerable<SuperPower> GetSuperPowers()
        {
            var superPowers = context.SuperPowers.Select(mapper.Map);
            return superPowers;
        }

        public SuperPower UpdateSuperPower(SuperPower superPower)
        {
            var updateThisSuperPower = GetSuperPowerById(superPower.Id);
            updateThisSuperPower.Name = superPower.Name;
            updateThisSuperPower.OwnerId = superPower.OwnerId;
            updateThisSuperPower.Description = superPower.Description;
            context.SaveChanges();
            return updateThisSuperPower;
        }
    }
}
