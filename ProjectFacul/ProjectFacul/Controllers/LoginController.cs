using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ProjectFacul.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
