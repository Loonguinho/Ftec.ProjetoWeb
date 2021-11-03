using Microsoft.AspNetCore.Mvc;
using ProjectFacul.ClientHttp;
using ProjectFacul.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFacul.Controllers
{
    public class FatoresClimaticosController : Controller
    {
        [HttpGet]
        public IActionResult Index(int id)
        { 
            APIHttpClient clienteHTTP = new APIHttpClient("http://localhost:51930/api/");
            List<FatoresClimaticosModel> produtos = clienteHTTP.Get<List<FatoresClimaticosModel>>(@"produto");
            return View(produtos);
        }
    }

    
}
