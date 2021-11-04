using ProjectFacul.Application.DTO;
using ProjectFacul.Domain.Entities;
using System;

namespace ProjectFacul.Application.Adapter
{
    class FatoresClimaticosAdapter
    {
        public static FatoresClimaticosDTO ParaFatoresClimaticosDTO(FatoresClimaticos fatorClimatico)
        {
            return new FatoresClimaticosDTO()
            {
                Id = fatorClimatico.Id,
                Data = DateTime.Now,
                Humidade = fatorClimatico.Humidade,
                IndicePluviometrico = fatorClimatico.IndicePluviometrico,
                Temperatura = fatorClimatico.Temperatura

            };
        }

        public static FatoresClimaticos ParaFatoresClimaticosDominio(FatoresClimaticosDTO fatorClimatico)
        {
            return new FatoresClimaticos()
            {
                Id = fatorClimatico.Id,
                Data = DateTime.Now,
                Humidade = fatorClimatico.Humidade,
                IndicePluviometrico = fatorClimatico.IndicePluviometrico,
                Temperatura = fatorClimatico.Temperatura

            };
        }
    }
}

