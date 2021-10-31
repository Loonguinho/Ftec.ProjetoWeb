using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectFacul.ProjetoWeb.Api.Model;
using System;

namespace ProjectFacul.ProjetoWeb.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FatoresClimaticosController : ControllerBase
    {
        private readonly ILogger<FatoresClimaticosController> _logger;

        public FatoresClimaticosController(ILogger<FatoresClimaticosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var rng = new Random();
            var fatoresClimaticos = new FatoresClimaticos()
            {
                id = Guid.NewGuid(),
                Data = DateTime.Now,
                Temperatura = rng.Next(-20, 55),
                IndicePluviometrico = "Chuva",
                Humidade = "86%"
            };

            return Ok(fatoresClimaticos);
        }

        [HttpPost]
        public IActionResult Post([FromBody] FatoresClimaticos fatoresCli)
        {
            return Ok(fatoresCli.id);
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] FatoresClimaticos fatoresCli)
        {
            return Ok(fatoresCli.id);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return Ok(true);
        }
    }
}
