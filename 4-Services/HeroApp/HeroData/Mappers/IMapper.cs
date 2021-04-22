using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroData.Mappers
{
    interface IMapper
    {
        HeroDomain.Models.SuperHero Map(HeroData.Entities.SuperHero superHero);
        HeroData.Entities.SuperHero Map(HeroDomain.Models.SuperHero superHero);
        HeroDomain.Models.SuperPower Map(HeroData.Entities.SuperPower superPower);
        HeroData.Entities.SuperPower Map(HeroDomain.Models.SuperPower superPower);
    }
}
