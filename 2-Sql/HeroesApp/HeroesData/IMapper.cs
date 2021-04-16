using HeroesLib.Models;

namespace HeroesData
{
    public interface IMapper
    {
        HeroesLib.Models.SuperHero Map(HeroesData.Entities.SuperHero superHero);
        HeroesData.Entities.SuperHero Map(HeroesLib.Models.SuperHero superHero);
         
    }
}