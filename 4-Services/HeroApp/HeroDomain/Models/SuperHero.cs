using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroDomain.Models
{
    public class SuperHero
    {
        public int Id { get; set; }
        public string RealName { get; set; }
        private string _alias;
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
        public string HideOut { get; set; }
        public SuperPower SuperPower { get; set; }
    }
}
