using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectFacul.Models;
using System.Diagnostics;
using Newtonsoft.Json;
using ProjectFacul.Mvc.Models;
using System.Collections.Generic;

namespace ProjectFacul.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RetornarDadosGraficoTemperatura()
        {
            //Consumir o servico que faz a comnsulta da temperatura
            List<DadosGraficoTemperaturaModel> listaDadosTemperatura = new List<DadosGraficoTemperaturaModel>();

            return Json(listaDadosTemperatura);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Home()
        {
            return View();
        }
    }
}
