using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjectFacul.ClientHttp;
using ProjectFacul.Models;
using System;

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

        public IActionResult Autenticar(string usuario, string senha)
        {
            UsuarioModel usu = new UsuarioModel()
            {
                Usuario_ = usuario,
                Senha = senha
            };
            //consumir a api de autenticacao
            APIHttpClient clienteHTTP = new APIHttpClient("https://projectfaculprojetowebapibackend.azurewebsites.net/api/");
            try
            {
                usu = clienteHTTP.Post<UsuarioModel>(@"Login", usu);
                //se estiver autenticado direciona para o home, e armazena em um cookie o token de autenticao
                return RedirectToAction("Home", "Home");
            }
            catch (Exception e){
                //se nao estiver autenticado direciona novamente para a tela de login com mensagem de usuario ou senha invalido
               return  RedirectToAction("Login");
            }
        }
    }
}
