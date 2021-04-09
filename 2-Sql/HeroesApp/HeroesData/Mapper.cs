namespace HeroesData
{
    public class Mapper : IMapper
    {
        public HeroesLib.Models.SuperHero Map(Entities.SuperHero superHero)
        {
            return new HeroesLib.Models.SuperHero{
               Id=superHero.Id,
               Alias=superHero.Alias,
               HideOut=superHero.HideOut,
               RealName=superHero.RealName
           };
        }

        public Entities.SuperHero Map(HeroesLib.Models.SuperHero superHero)
        {
           return new HeroesData.Entities.SuperHero{
                Id=superHero.Id,
                Alias=superHero.Alias,
                HideOut=superHero.HideOut,
                RealName=superHero.RealName
            };
        }
    }
}