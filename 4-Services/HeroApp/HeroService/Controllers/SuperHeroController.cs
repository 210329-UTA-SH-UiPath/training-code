using HeroService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        // In memory Data
        static List<SuperHero> superHeroes = new List<SuperHero>() {
        new SuperHero(){id=1,realName="BruceWayne",alias="Batman",hideOut="Batcave"},
        new SuperHero(){id=2,realName="Peter Parker",alias="Spiderman",hideOut="in his apartment"},
        new SuperHero(){id=3,realName="Thor",alias="Thor",hideOut="Asgard" }
        };

        [HttpGet]
        //public ActionResult<SuperHero> Get()
        public IEnumerable<SuperHero> Get()// Specific type
        {
            // return Ok(superHeroes);
            return superHeroes;
        }
        [HttpGet("{id}")]
        //public ActionResult<SuperHero> Get(int id)
        public SuperHero Get(int id)
        {
            var superHero=superHeroes.Find(x => x.id == id);
            if (superHero == null)
                //return NotFound($"The super hero with id {id} is not in the database");
                return superHero;
            else
                return superHero;
        }
        [HttpPost]
        public IActionResult Post(SuperHero superHero)
        {
            if (superHero != null)
            {
                superHeroes.Add(superHero);
                return NoContent();
            }
            else
                return BadRequest("May be check your supper hero data, either it is null or invalid");

        }
        [HttpPut]
        public IActionResult Put(SuperHero superHero)
        {
            var superHeroFind = superHeroes.Find(x => x.id == superHero.id);
            if (superHeroFind != null)
            {
                superHeroes.Add(superHero);
                return NoContent();
            }
            else
                return BadRequest("May be check your supper hero data, either it is null or invalid");

        }
    }
}
