using System;
using System.Collections.Generic;

#nullable disable

namespace HeroesData.Entities
{
    public partial class SuperHero
    {
        public SuperHero()
        {
            SuperPowers = new HashSet<SuperPower>();
        }

        public decimal Id { get; set; }
        public string RealName { get; set; }
        public string Alias { get; set; }
        public string HideOut { get; set; }

        public virtual ICollection<SuperPower> SuperPowers { get; set; }
    }
}
