using System;
using HeroesData.Enities;
using System.Collections.Generic;
using System.Linq;

namespace HeroesConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fetching Super Hero");
            var superHeroes=GetSuperHeroes();
            foreach (var superHero in superHeroes)
            {
                  Console.WriteLine($"{superHero.Id} {superHero.RealName} {superHero.Alias}");
            }
        }
        static List<SuperHero> GetSuperHeroes(){
            // This will create a session between DB and the .Net app
            HeroesDbContext context=new HeroesDbContext();
            var superHeroes=context.SuperHeroes.ToList();
            return superHeroes;          
        }
    }
}
