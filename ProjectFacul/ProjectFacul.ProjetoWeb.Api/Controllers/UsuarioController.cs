using Microsoft.AspNetCore.Mvc;
using ProjectFacul.ProjetoWeb.Api.Model;
using System;

namespace ProjectFacul.ProjetoWeb.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        public UsuarioController()
        {

        }

        public IActionResult GET()
        {
            var usuario = new Usuario()
            {
                UsuarioID = Guid.NewGuid(),
                Nome = "Guilherme Vargas",
                DataNascimento = DateTime.Now,
                Genero = "Masculino",
                Idade = 21
            };
            return Ok(usuario);
        }


        [HttpPost]
        public IActionResult Post([FromBody] Usuario user)
        {
            return Ok(user.UsuarioID);
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Usuario user)
        {
            return Ok(user.UsuarioID);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return Ok(true);
        }
    }
}
