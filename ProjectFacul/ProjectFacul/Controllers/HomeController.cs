using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectFacul.Models;
using System.Diagnostics;
using Newtonsoft.Json;
using ProjectFacul.Mvc.Models;
using System.Collections.Generic;
using System.Data;
using ProjectFacul.ClientHttp;
using System;

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
        [HttpPost]
        public JsonResult RetornarDadosGraficoTemperatura()
        {
            List<List<string>> saida = new List<List<string>>();
            //Consumir o servico que faz a comnsulta da temperatura
            List<DadosGraficoTemperaturaModel> listaDadosTemperatura = new List<DadosGraficoTemperaturaModel>();

            //consumir a api de autenticacao
            APIHttpClient clienteHTTP = new APIHttpClient("http://localhost:48678/api/");
            try
            {
                listaDadosTemperatura = clienteHTTP.Get<List<DadosGraficoTemperaturaModel>>(@"Temperatura");
                DataTable dt = new DataTable();
                dt.Columns.Add("Temperatura", System.Type.GetType("System.String"));
                dt.Columns.Add("Data", System.Type.GetType("System.DateTime"));
            
                foreach (var item in listaDadosTemperatura)
                {
                    DataRow dr = dt.NewRow();
                    dr["Temperatura"] = item.Temperatura;
                    dr["Data"] = item.Data;
                    
                    DateTime datahoje = DateTime.Now;
                    string dataDia = datahoje.ToShortDateString();
                    DateTime dataInicio = DateTime.Parse($"{dataDia} 06:00:00");
                    DateTime dataFinal = DateTime.Parse($"{dataDia} 09:00:00");
                    
                    //converter temperatura para celsius

                    if (dataInicio <= item.Data && dataFinal >= item.Data)
                    {
                        dt.Rows.Add(dr);
                    }
                    

                }


                List<string> datas = new List<string>();
                List<string> temperaturas = new List<string>();
                

                foreach (DataRow row in dt.Rows)
                {
                    datas.Add(row["Data"].ToString());
                    temperaturas.Add(row["Temperatura"].ToString());

                }
                saida.Add(datas);
                saida.Add(temperaturas);

            }
            catch (Exception e)
            {
            }
            return Json(saida);
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
