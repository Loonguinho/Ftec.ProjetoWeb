﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjectFacul.ClientHttp;
using ProjectFacul.Models;
using System.Collections.Generic;

namespace ProjectFacul.Controllers
{
    public class UsuárioController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
                APIHttpClient clienteHTTP = new APIHttpClient("http://localhost:48678/api/");
                List<UsuarioModel> produtos = clienteHTTP.Get<List<UsuarioModel>>(@"Usuario");
                return View(produtos);
            }
        }

        //public IActionResult Cadastrar()
        //{
        //    return View();
        //}
    }

