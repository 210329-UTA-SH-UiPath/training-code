using System;
using System.Collections.Generic;
using System.Linq;
using HeroesLib;

namespace HeroesConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository repository=Dependencies.CreateRepository();
         
            Console.WriteLine("Fetching Super Hero");
            RunUI(repository);
          
        }
       public static void RunUI(IRepository repository){
           /*var SuperHeroes = repository.GetAllSuperHeros();
           foreach (var superhero in SuperHeroes)
           {
               Console.WriteLine($"{superhero.Id} {superhero.Alias} {superhero.RealName}  {superhero.HideOut}");
           }*/

          /* Console.WriteLine("Please enter the name of Super hero you are looking to search for");
           var name=Console.ReadLine();
           var superhero= repository.GetSuperHeroByName(name);
           Console.WriteLine($"{superhero.Id} {superhero.Alias} {superhero.RealName}  {superhero.HideOut}");*/
           Console.Write("Please enter the SuperHero alias");
           string _alias = Console.ReadLine();
           Console.Write("Please enter the SuperHero real name");
           string _realName = Console.ReadLine();
           Console.Write("Please enter the SuperHero hide out place");
           string _hideOut = Console.ReadLine();

           HeroesLib.Models.SuperHero superHero= new HeroesLib.Models.SuperHero{
              Alias=_alias,
              HideOut=_hideOut,
              RealName=_realName
           };
           repository.Add(superHero);
           Console.WriteLine( $"Super hero {_alias} is added"   );
           var SuperHeroes = repository.GetAllSuperHeros();
           foreach (var superhero in SuperHeroes)
           {
               Console.WriteLine($"{superhero.Id} {superhero.Alias} {superhero.RealName}  {superhero.HideOut}");
           }
       }
    }
}
