using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProjectFacul.Application;
using ProjectFacul.Domain.Entities;
using ProjectFacul.Domain.Repository;
using ProjectFacul.ProjetoWeb.Api.Model;
using ProjectFacul.Repository;
using System.Collections.Generic;

namespace ProjectFacul.ProjetoWeb.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TemperaturaController : ControllerBase
    {
        private IFatoresClimaticosRepository fatoresClimaticosRepository;
        private FatoresClimaticosApplication fatoresClimaticosApplication;

        public TemperaturaController(IConfiguration configuration)
        {
            string conexao = configuration.GetConnectionString("conexao");
            fatoresClimaticosRepository = new FatoresClimaticosRepository(conexao);
            fatoresClimaticosApplication = new FatoresClimaticosApplication(fatoresClimaticosRepository);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var fatoresClimaticos = fatoresClimaticosApplication.SelecionarTodos();
            List<DadosTemperatura> fatoresModel = new List<DadosTemperatura>();

            foreach (var fatorDTO in fatoresClimaticos)
            {
                fatoresModel.Add(new DadosTemperatura()
                {
                    Temperatura = fatorDTO.Temperatura,
                    Data = fatorDTO.Data,
                });
            }

            return Ok(fatoresModel);
        }
    }
}
