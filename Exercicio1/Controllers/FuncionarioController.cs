using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ftec.ProjetoWeb.Excercicio1.Controllers
{
    public class FuncionarioController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult Listar() => View();

        public IActionResult Gravar() => View();

        public IActionResult Excluir() => View();

        public IActionResult Procurar() => View();
    }
}
