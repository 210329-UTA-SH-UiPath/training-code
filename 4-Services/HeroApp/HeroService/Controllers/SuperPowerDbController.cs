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
        public ActionResult<SuperPower> Get()
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
        public ActionResult<SuperPower> Get(int id)
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

        [HttpDelete]
        public ActionResult<SuperPower> Delete(int id)
        {
            repo.DeleteSuperPower(id);
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] SuperPower SuperPower) //model binder of asp.net core will look for this parameter from request body
        {
            if (SuperPower == null)
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
                    repo.AddSuperPower(SuperPower);
                    return CreatedAtAction(nameof(Get), new { id = SuperPower.Id }, SuperPower);
                }
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] SuperPower SuperPower) //model binder of asp.net core will look for this parameter from request body
        {
            if (SuperPower == null)
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
                    repo.UpdateSuperPower(SuperPower);
                    return CreatedAtAction(nameof(Get), new { id = SuperPower.Id }, SuperPower);
                }
            }
        }
    }
}
