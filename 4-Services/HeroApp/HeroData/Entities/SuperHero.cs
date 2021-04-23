using System;
using System.ComponentModel.DataAnnotations;//validations and constraints
using System.ComponentModel.DataAnnotations.Schema;//constraints and display


namespace HeroData.Entities
{
    [Table("superhero")]
   public class SuperHero
    {
        public SuperHero()
        {

        }
        public SuperHero(int id, string realName, string alias, string hideOut)
        {
            Id = id;
            RealName = realName;
            Alias = alias;
            HideOut = hideOut;
        }
        //[Key] - this makes sure if EFCore convention is not used this will represent the property annotated as a PK
        //By default if EFCore finds there is an Id or <className>Id property of int type it will create it as a PK in the DB
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string RealName { get; set; }
        [Required]
        [StringLength(50)]
        public string Alias { get; set; }
        [StringLength(50)]
        public string HideOut { get; set; }
        // 1 to many relationship
        //public virtual ICollection<SuperPower> SuperPower { get; set; }
        public virtual SuperPower SuperPower { get; set; } //virtual here means the values are lazily loaded.
    }
}
