﻿using Microsoft.AspNetCore.Mvc;
using MVCFrontEnd.Models;
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
        /// <summary>
        /// This action will return you a scaffolded form
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ViewResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add([Bind("Alias, RealName, HideOut")]SuperHero superHero)
        {
            if (ModelState.IsValid)
            {
                client.AddSuperHero(superHero);
                return RedirectToAction("Index");
            }
            else
            {
                return View(superHero);
            }
        }

        [HttpPost]
        public IActionResult Edit([Bind("Id, Alias, RealName, HideOut")] SuperHero superHero)
        {
            if (ModelState.IsValid)
            {
                client.UpdateSuperHero(superHero);
                RedirectToAction("Index");
            }
            return View(superHero);
        }

        [HttpDelete]
        public IActionResult Delete([Bind("Id, Alias, RealName, HideOut")] SuperHero superHero)
        {

            if (client.GetSuperHeroById(superHero.Id) is null)
            {
                // should never actually be hit but might as well check for it
                return View();
            }
            client.DeleteSuperHero(superHero.Id);
            return RedirectToAction("Index");
        }



    }
}
