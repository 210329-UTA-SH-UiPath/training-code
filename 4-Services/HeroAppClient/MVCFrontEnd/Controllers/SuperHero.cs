using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFrontEnd.Controllers
{
    public class SuperHero : Controller
    {
        Client client = new Client();
        public IActionResult Index()
        {
            var superHeros=client.GetAllSuperHeroes();
            return View(superHeros);
        }
    }
}
