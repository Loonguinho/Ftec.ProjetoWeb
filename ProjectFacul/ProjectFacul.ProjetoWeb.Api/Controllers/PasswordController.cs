using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFacul.ProjetoWeb.Api.Controllers
{
    public class PasswordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
