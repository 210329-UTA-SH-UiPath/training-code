using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerDomain.Abstraction;
using PowerDomain.Models;

namespace PowerData.Repositories
{
    public class SuperPowerRepository : ISuperPowerRepository
    {
        private readonly Entities.SuperPowerContext context;
        Mappers.IMapper mapper = new Mappers.Mapper();
        public SuperPowerRepository(Entities.SuperPowerContext context)
        {
            this.context = context;
        }
        public void AddSuperPower(SuperPower superPower)
        {
            throw new NotImplementedException();
        }

        public void DeleteSuperPower(int id)
        {
            throw new NotImplementedException();
        }

        public SuperPower GetSuperPowerById()
        {
            throw new NotImplementedException();
        }

        public SuperPower GetSuperPowerByName()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SuperPower> GetSuperPowers()
        {
            var superPowers = context.SuperPowers.Select(mapper.Map);
            return superPowers;
        }

        public SuperPower UpdateSuperPower(SuperPower superPower)
        {
            throw new NotImplementedException();
        }
    }
}
