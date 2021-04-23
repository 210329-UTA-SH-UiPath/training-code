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
        public SuperHeroRepository(Entities.SuperHeroContext context)
        {
            this.context = context;
        }

        public IEnumerable<SuperPower> GetSuperPowers()
        {
            var superPowers = context.SuperPowers.Select(mapper.Map);
            return superPowers;
        }
        public SuperPower GetSuperPowerById(int id)
        {
            var SuperPower = context.SuperPowers.Where(x => x.Id == id).FirstOrDefault();
            if (SuperPower == null)
            {
                return null;
            }
            return mapper.Map(SuperPower);
        }
        public SuperPower GetSuperPowerByName(string name)
        {
            var SuperPower = context.SuperPowers.Where(x => x.Name == name).FirstOrDefault();
            if (SuperPower == null)
            {
                return null;
            }
            return mapper.Map(SuperPower);
        }
        public void AddSuperPower(SuperPower superPower)
        {
            context.Add(mapper.Map(superPower));
            context.SaveChanges();
        }
        public SuperPower UpdateSuperPower(SuperPower superPower)
        {
            var record = context.SuperPowers.FirstOrDefault(x => x.Id == superPower.Id);
            record.Name = superPower.Name;
            record.Description = superPower.Description;
            record.OwnerId = superPower.OwnerId;
            context.update(record);
            context.SaveChanges();
            return mapper.map(record);
        }
        public void DeleteSuperPower(int id)
        {
            var superPower = context.SuperPowers.FirstOrDefault(x => x.Id == superPower.Id);
            context.delete(superPower);
            context.saveChanges();
        }
    }
}