using Microsoft.AspNetCore.Mvc;
using ProjectFacul.Application;
using ProjectFacul.Application.DTO;
using ProjectFacul.Domain.Repository;
using ProjectFacul.ProjetoWeb.Api.Model;
using ProjectFacul.Repository;
using System;
using System.Collections.Generic;

namespace ProjectFacul.ProjetoWeb.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository usuarioRepository;
        private UsuarioApplication usuarioApplication;
        public UsuarioController()
        {
            usuarioRepository = new UsuarioRepository();
            usuarioApplication = new UsuarioApplication(usuarioRepository);
        }

        [HttpGet]
        public IActionResult Get()
        {
            //Agora a camada de controller interage com a camada de aplicação recebendo os dados do serviço e manda pra camada de aplicação.

            try
            {
                var usuarios = usuarioApplication.SelecionarTodos();

                List<Usuario> usuariosModel = new List<Usuario>();

                foreach (var userDTO in usuarios)
                {
                    usuariosModel.Add(new Usuario()
                    {
                        DataNascimento = userDTO.DataNascimento,
                        Genero = userDTO.Genero,
                        Idade = userDTO.Idade,
                        Nome = userDTO.Nome,
                        Id = userDTO.Id,
                    });
                }

                return Ok(usuariosModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpPost]
        public IActionResult Post([FromBody] Usuario user)
        {
            try
            {
                UsuarioDTO usuarioDTO = new UsuarioDTO()
                {
                    DataNascimento = user.DataNascimento,
                    Genero = user.Genero,
                    Idade = user.Idade,
                    Nome = user.Nome,
                    Id = user.Id,
                };

                Guid id = usuarioApplication.Adicionar(usuarioDTO);

                return Ok(id);
            }
            catch (Exception ex )
            {
                return BadRequest(ex);
            } 

        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Usuario user)
        {
            try
            {
                UsuarioDTO usuarioDTO = new UsuarioDTO()
                {
                    DataNascimento = user.DataNascimento,
                    Genero = user.Genero,
                    Idade = user.Idade,
                    Nome = user.Nome,
                    Id = user.Id,
                };

                usuarioApplication.Alterar(usuarioDTO);

                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                usuarioApplication.Deletar(id);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }
    }
}
