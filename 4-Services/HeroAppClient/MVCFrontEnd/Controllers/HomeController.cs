using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCFrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFrontEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        SuperHero superHero = new SuperHero() {
             Id=1,
             Alias="Spiderman",
             RealName="Peter Parker",
             HideOut="His apartment in Manhattan"
        };
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //ViewData["superhero"]="Spider man";
            //ViewData["superhero"] = superHero;
            ViewBag.superhero = superHero;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
