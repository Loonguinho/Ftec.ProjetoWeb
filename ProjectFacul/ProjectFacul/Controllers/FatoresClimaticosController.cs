using Microsoft.AspNetCore.Mvc;
using ProjectFacul.ClientHttp;
using ProjectFacul.Models;
using System.Collections.Generic;

namespace ProjectFacul.Controllers
{
    public class FatoresClimaticosController : Controller
    {
        [HttpGet]
        public IActionResult Index(int id)
        { 
            APIHttpClient clienteHTTP = new APIHttpClient("https://projectfaculprojetowebapibackend.azurewebsites.net/api/");
            List<FatoresClimaticosModel> produtos = clienteHTTP.Get<List<FatoresClimaticosModel>>(@"fatoresClimaticos");
            return View(produtos);
        }
    }

    
}
