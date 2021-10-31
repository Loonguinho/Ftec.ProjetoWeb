using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectFacul.ProjetoWeb.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FatoresClimaticosController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<FatoresClimaticosController> _logger;

        public FatoresClimaticosController(ILogger<FatoresClimaticosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<FatoresClimaticos> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new FatoresClimaticos
            {
                Data = DateTime.Now.AddDays(index),
                TemperaturaC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
