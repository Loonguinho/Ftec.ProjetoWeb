using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ProjectFacul.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
