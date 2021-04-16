    using System;

    namespace HeroesLib.Models{
        public class SuperHero
        {
            public decimal Id { get; set; }
            public string RealName { get; set; }
            private string _alias;
            public string Alias {

                get => _alias;
                set {
                    if(value.Length==0){
                        throw new ArgumentException("SuperHero Alias must not be empty", nameof(value));
                    }
                    _alias=value;
                }
             }
            public string HideOut { get; set; }
        }
    }