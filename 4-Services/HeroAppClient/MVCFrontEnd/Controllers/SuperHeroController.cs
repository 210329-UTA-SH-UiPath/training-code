using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFrontEnd.Controllers
{
    public class SuperHeroController : Controller
    {
        Client client = new Client();
        public IActionResult Index()
        {
            var superHeros=client.GetAllSuperHeroes();
        
            return View(superHeros);
        }
        public ContentResult About()
        {
           return Content("This is a SuperHero App");
        }
        public ViewResult GetById(int id)
        {
            var superHero = client.GetSuperHeroById(id);
            return View("IndexById",superHero);
        }
    }
}
