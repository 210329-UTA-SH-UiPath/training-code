using HeroDomain.Abstraction;
using HeroDomain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroService.Controllers
{
    [Route("api/[controller]")]
    public class SuperPowerDbController : MyControllerBase
    {
        private readonly ISuperPowerRepository repo;
        public SuperPowerDbController(ISuperPowerRepository repo)
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
                return Ok(repo.GetSuperPowers());
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<SuperHero> Get(int id)
        {
            try
            {
                return Ok(repo.GetSuperPowerById(id));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
