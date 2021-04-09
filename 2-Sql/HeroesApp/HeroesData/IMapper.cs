using HeroesLib.Models;

namespace HeroesData
{
    public interface IMapper
    {
        HeroesLib.Models.SuperHero Map(HeroesData.Enities.SuperHero superHero);
        HeroesData.Enities.SuperHero Map(HeroesLib.Models.SuperHero superHero);
         
    }
}