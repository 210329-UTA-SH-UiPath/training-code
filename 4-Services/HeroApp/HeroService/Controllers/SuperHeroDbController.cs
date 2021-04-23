using HeroDomain.Abstraction;
using HeroDomain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace HeroService.Controllers
{
    [Route("api/[controller]")]
    public class SuperHeroDbController : MyControllerBase
    {
        private readonly ISuperHeroRepository repo;
        public SuperHeroDbController(ISuperHeroRepository repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<SuperHero> Get()
        {
            try
            {
                return Ok(repo.GetSuperHeroes());
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<SuperHero> Get([FromRoute]int id)
        {
            try
            {
                return Ok(repo.GetSuperHeroById(id));
            }
            catch (Exception ex)
            {
                return NotFound($"The superhero by id - {id} does not exist");
            }
        }
        [HttpGet("{name}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<SuperHero> Get([FromQuery]string name)
        {
            try
            {
                return Ok(repo.GetSuperHeroByAlias(name));
            }
            catch (Exception ex)
            {
                return StatusCode(404, ex.Message);
            }
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[Consumes("application/json")]
        [Consumes(MediaTypeNames.Application.Json)]
        public IActionResult Post(SuperHero superHero) 
        {
            if (superHero == null)
            {
                return BadRequest("The super hero you are trying to add is empty");
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    repo.AddSuperHero(superHero);
                    return CreatedAtAction(nameof(Get), new { id=superHero.Id},superHero);
                }
            }
        }

    }
}
