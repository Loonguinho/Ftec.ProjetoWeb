using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectFacul.Models;
using System.Diagnostics;
using Newtonsoft.Json;
using ProjectFacul.Mvc.Models;
using System.Collections.Generic;
using System.Data;

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
        public JsonResult RetornarDadosGraficoTemperatura()
        {
            //Consumir o servico que faz a comnsulta da temperatura
            List<DadosGraficoTemperaturaModel> listaDadosTemperatura = new List<DadosGraficoTemperaturaModel>();

            DataTable dt = new DataTable();
            dt.Columns.Add("Temperatura", System.Type.GetType("System.String"));
            dt.Columns.Add("Data", System.Type.GetType("System.DateTime"));

            foreach (var item in listaDadosTemperatura)
            {
                DataRow dr = dt.NewRow();
                dr["Temperatura"] = item.Temperatura;
                dr["Data"] = item.Data;
                dt.Rows.Add(dr);
            }
            foreach (DataColumn dc in dt.Columns)
            {
                List<DadosGraficoTemperaturaModel> x = new List<DadosGraficoTemperaturaModel>();
                x = (from DataRow drr in dt.Rows select drr[dc.ColumnName]).ToList();
                listaDadosTemperatura.Add(x);
            }
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
