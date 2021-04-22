using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroData.Entities
{
    public class SuperPower
    {
        public SuperPower()
        {

        }
        public SuperPower(int id, string name, string description, int? ownerid)
        {
            Id = id;
            Name = name;
            Description = description;
            OwnerId = ownerid;
        }
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        public int? OwnerId { get; set; }
        public virtual SuperHero Owner { get; set; }
    }
}
