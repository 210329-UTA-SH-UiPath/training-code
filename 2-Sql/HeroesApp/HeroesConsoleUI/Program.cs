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
      IRepository repository = Dependencies.CreateRepository();

      Console.WriteLine("Fetching Super Hero");
      RunUI(repository);

    }
    public static void RunUI(IRepository repository)
    {
      RunUIPrintAllHeroes(repository);
      RunUIUpdateAHero(repository);
      RunUIDeleteAHero(repository);
    }

    public static void RunUIGetAHero(IRepository repository)
    {
      Console.WriteLine("Please enter the name of Super hero you are looking to search for");
      var name = Console.ReadLine();
      var superhero = repository.GetSuperHeroByName(name);
      Console.WriteLine($"{superhero.Id} {superhero.Alias} {superhero.RealName}  {superhero.HideOut}");

    }
    public static void RunUIPrintAllHeroes(IRepository repository)
    {
      var SuperHeroes = repository.GetAllSuperHeros();
      foreach (var superhero in SuperHeroes)
      {
        Console.WriteLine($"{superhero.Id} {superhero.Alias} {superhero.RealName}  {superhero.HideOut}");
      }


    }
    public static void RunUIAddAHero(IRepository repository)
    {
      RunUIPrintAllHeroes(repository);


      Console.Write("Please enter the SuperHero alias");
      string _alias = Console.ReadLine();
      Console.Write("Please enter the SuperHero real name");
      string _realName = Console.ReadLine();
      Console.Write("Please enter the SuperHero hide out place");
      string _hideOut = Console.ReadLine();

      HeroesLib.Models.SuperHero superHero = new HeroesLib.Models.SuperHero
      {
        Alias = _alias,
        HideOut = _hideOut,
        RealName = _realName
      };
      repository.Add(superHero);
      Console.WriteLine($"Super hero {_alias} is added");

      RunUIPrintAllHeroes(repository);

    }

    public static void RunUIUpdateAHero(IRepository repository)
    {
      Console.WriteLine("Please enter the name of the Super hero you are looking to update");
      var name = Console.ReadLine();
      var superhero = repository.GetSuperHeroByName(name);
      Console.Write("Please enter hero's new alias");
      string _alias = Console.ReadLine();
      Console.Write("Please enter hero's new hideout");
      string _hideOut = Console.ReadLine();
      superhero.Alias = _alias;
      superhero.HideOut = _hideOut;
      Console.WriteLine(repository.Update(superhero) + "Has been updated");

      RunUIPrintAllHeroes(repository);

    }

    public static void RunUIDeleteAHero(IRepository repository)
    {
      Console.WriteLine("Enter the name of the hero you want to delete");
      var name = Console.ReadLine();
      var superhero = repository.GetSuperHeroByName(name);
      Console.WriteLine(superhero + "will be deleted");
      repository.Delete(superhero);

      RunUIPrintAllHeroes(repository);

       /* static void Main(string[] args)
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
          /* Console.Write("Please enter the SuperHero alias");
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
       }*/
    }
  }
}
