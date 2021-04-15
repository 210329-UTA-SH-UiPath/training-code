using System;
using System.Collections.Generic;

#nullable disable

namespace HeroesData.Entities
{
    public partial class SuperPower
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public decimal? SuperHeroId { get; set; }

        public virtual SuperHero SuperHero { get; set; }
    }
}
