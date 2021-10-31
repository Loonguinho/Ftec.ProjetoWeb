using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProjectFacul.Controllers
{
    public class SenhaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RecuperarSenha()
        {
            return View();
        }
    }
}
