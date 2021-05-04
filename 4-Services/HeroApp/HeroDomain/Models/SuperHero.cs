using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroDomain.Models
{
    public class SuperHero
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string RealName { get; set; }
        private string _alias;
        [StringLength(30)]
        public string Alias
        {

            get => _alias;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("SuperHero Alias must not be empty", nameof(value));
                }
                _alias = value;
            }
        }
        [StringLength(50)]
        public string HideOut { get; set; }
        public SuperPower SuperPower { get; set; }
    }
}
