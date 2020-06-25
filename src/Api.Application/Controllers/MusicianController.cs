using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.IRepositories;
using Domain.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Application.Controllers
{
    [ApiController]
    [Route("musicians")]
    public class MusicianController : ControllerBase
    {
        private readonly ILogger<ControllerBase> _logger;
        private readonly IMusicianService _service;

        public MusicianController(
            [FromServices] IMusicianService service, 
            [FromServices] ILogger<ControllerBase> logger)
        {
            this._logger = logger;
            this._service = service;
        }

        [HttpPost]
        [Route("")]
        public ActionResult<Musician> PostMusician(
            [FromBody] Musician musician)
        {
            try
            {
                return Ok(this._service.Add(musician));     
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
              
        [HttpPut]
        [Route("{id}")]
        public ActionResult<Musician> PutMusician(
            [FromRoute] string id,
            [FromBody] Musician musician)
        {
            try
            {
                return Ok(this._service.Add(musician));     
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

             
        [HttpDelete]
        [Route("{id}")]
        public ActionResult<Musician> DeleteMusician(
            [FromRoute] string id)
        {
            try
            {
                return Ok(this._service.Delete(id));     
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Musician> GetMusician(
            [FromRoute] string id)
        {
            try
            {
                return Ok(this._service.Get(id));     
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("")]
        public ActionResult<IEnumerable<Musician>> GetMusicians()
        {
            try
            {
                return Ok(this._service.List());     
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}
