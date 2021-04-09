namespace HeroesData
{
    public class Mapper : IMapper
    {
        public HeroesLib.Models.SuperHero Map(Enities.SuperHero superHero)
        {
            return new HeroesLib.Models.SuperHero{
               Id=superHero.Id,
               Alias=superHero.Alias,
               HideOut=superHero.HideOut,
               RealName=superHero.RealName
           };
        }

        public Enities.SuperHero Map(HeroesLib.Models.SuperHero superHero)
        {
           return new HeroesData.Enities.SuperHero{
                Id=superHero.Id,
                Alias=superHero.Alias,
                HideOut=superHero.HideOut,
                RealName=superHero.RealName
            };
        }
    }
}