using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroData.Mappers
{
    class Mapper : IMapper
    {
        public HeroDomain.Models.SuperHero Map(Entities.SuperHero superHero)
        {
            return new HeroDomain.Models.SuperHero()
            {
                Id = superHero.Id,
                RealName = superHero.RealName,
                HideOut = superHero.HideOut,
                Alias = superHero.Alias
            };
        }

        public Entities.SuperHero Map(HeroDomain.Models.SuperHero superHero)
        {
            return new Entities.SuperHero()
            {
                Id = superHero.Id,
                Alias = superHero.Alias,
                HideOut = superHero.HideOut,
                RealName = superHero.RealName
            };
        }

        public HeroDomain.Models.SuperPower Map(Entities.SuperPower superPower)
        {
            //please implemenet and make a PR for the same
            return new HeroDomain.Models.SuperPower()
            {
                Id = superPower.Id,
                Name = superPower.Name,
                Description = superPower.Description,
                OwnerId = superPower.OwnerId
            };
        }

        public Entities.SuperPower Map(HeroDomain.Models.SuperPower superPower)
        {
            //please implemenet and make a PR for the same
            return new Entities.SuperPower()
            {
                Id = superPower.Id,
                Name = superPower.Name,
                Description = superPower.Description,
                OwnerId = superPower.OwnerId
            };
        }
    }
}
