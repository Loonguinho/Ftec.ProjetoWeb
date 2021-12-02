using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProjectFacul.Application;
using ProjectFacul.Domain.Repository;
using ProjectFacul.ProjetoWeb.Api.Model;
using ProjectFacul.Repository;
using System.Collections.Generic;

namespace ProjectFacul.ProjetoWeb.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PluviometricoController : ControllerBase
    {
        private IFatoresClimaticosRepository fatoresClimaticosRepository;
        private FatoresClimaticosApplication fatoresClimaticosApplication;

        public PluviometricoController(IConfiguration configuration)
        {
            string conexao = configuration.GetConnectionString("conexao");
            fatoresClimaticosRepository = new FatoresClimaticosRepository(conexao);
            fatoresClimaticosApplication = new FatoresClimaticosApplication(fatoresClimaticosRepository);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var fatoresClimaticos = fatoresClimaticosApplication.SelecionarTodos();
            List<DadosPluviometricos> fatoresModel = new List<DadosPluviometricos>();

            foreach (var fatorDTO in fatoresClimaticos)
            {
                fatoresModel.Add(new DadosPluviometricos()
                {
                    IndicePluviometrico = fatorDTO.IndicePluviometrico,
                    Data = fatorDTO.Data,
                });
            }

            return Ok(fatoresModel);
        }
    }
}
