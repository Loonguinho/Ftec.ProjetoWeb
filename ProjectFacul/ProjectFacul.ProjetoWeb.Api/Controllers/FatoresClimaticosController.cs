﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectFacul.Application;
using ProjectFacul.Application.DTO;
using ProjectFacul.Domain.Repository;
using ProjectFacul.ProjetoWeb.Api.Model;
using ProjectFacul.Repository;
using System;
using System.Collections.Generic;

namespace ProjectFacul.ProjetoWeb.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FatoresClimaticosController : ControllerBase
    {
        //private readonly ILogger<FatoresClimaticosController> _logger;
        private IFatoresClimaticosRepository fatoresClimaticosRepository;
        private FatoresClimaticosApplication fatoresClimaticosApplication;

        public FatoresClimaticosController()
        {
            fatoresClimaticosRepository = new FatoresClimaticosRapository();
            fatoresClimaticosApplication = new FatoresClimaticosApplication(fatoresClimaticosRepository);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var fatoresClimaticos = fatoresClimaticosApplication.SelecionarTodos();
            List<FatoresClimaticos> fatoresModel = new List<FatoresClimaticos>();

            foreach (var fatorDTO in fatoresClimaticos)
            {
                fatoresModel.Add(new FatoresClimaticos()
                {
                    Id = fatorDTO.Id,
                    //Humidade = fatorDTO.Humidade,
                    Temperatura = fatorDTO.Temperatura,
                    //IndicePluviometrico = fatorDTO.IndicePluviometrico,
                    Data = fatorDTO.Data,

                });
            }

            return Ok(fatoresModel);

        }
        [HttpPost]
        public IActionResult Post([FromBody] FatoresClimaticos fatores)
        {
            try
            {
                FatoresClimaticosDTO fatoresDTO = new FatoresClimaticosDTO()
                {
                    Id = fatores.Id,
                    Temperatura = fatores.Temperatura,
                    //Humidade = fatores.Humidade,
                    //IndicePluviometrico = fatores.IndicePluviometrico,
                    Data = fatores.Data,
                };

                Guid id = fatoresClimaticosApplication.Inserir(fatoresDTO);

                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] FatoresClimaticos fatores)
        {
            try
            {
                FatoresClimaticosDTO fatoresDTO = new FatoresClimaticosDTO()
                {
                    Id = fatores.Id,
                    Temperatura = fatores.Temperatura,
                    //Humidade = fatores.Humidade,
                    //IndicePluviometrico = fatores.IndicePluviometrico,
                    Data = fatores.Data,
                };

                fatoresClimaticosApplication.Alterar(fatoresDTO);

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
                    fatoresClimaticosApplication.Excluir(id);
                    return Ok(true);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex);
                }

            }
        }
    }




        