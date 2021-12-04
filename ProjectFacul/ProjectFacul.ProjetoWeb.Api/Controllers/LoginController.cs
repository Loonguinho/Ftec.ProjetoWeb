using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProjectFacul.Application;
using ProjectFacul.ProjetoWeb.Api.Model;
using ProjectFacul.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace ProjectFacul.ProjetoWeb.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private string strConexao;

        public LoginController(IConfiguration configuration)
        {
            strConexao = configuration.GetConnectionString("conexao");
        }

        [HttpPost]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Post([FromBody] Usuario userModel)
        {
            try
            {

                UsuarioRepository usuarioRepository = new UsuarioRepository(strConexao);
                UsuarioApplication usuarioApplication = new UsuarioApplication(usuarioRepository);

                var usuario = usuarioApplication.Autenticar(userModel.Usuario_, userModel.Senha);


                // Gera o Token
                var token = Services.TokenServices.GenerateToken(usuario);

                // Oculta a senha
                usuario.Senha = "";

                // Retorna os dados
                userModel.Token = token;

                return Ok(userModel);

            }
            catch (ApplicationException ae)
            {
                return BadRequest(ae.Message);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}
