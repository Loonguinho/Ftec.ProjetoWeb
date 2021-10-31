using ProjectFacul.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFacul.Application.Adapter
{
    class FatoresClimaticosAdapter
    {
        public static FatoresClimaticos ParaFatoresClimaticosDTO(FatoresClimaticos fatoresClimaticos)
        {
            return new FatoresClimaticos()
            {
                Temperatura = fatoresClimaticos.Temperatura,
                Humidade = fatoresClimaticos.Humidade,
                IndicePluviometrico = fatoresClimaticos.IndicePluviometrico,
                Data = fatoresClimaticos.Data,
                Id = fatoresClimaticos.FatoresId,
            };
        }
        public static FatoresClimaticos ParaUsuarioDominio(FatoresClimaticos fatoresClimaticosDTO)
        {
            return new FatoresClimaticos()
            {
                Temperatura = fatoresClimaticosDTO.Temperatura,
                Humidade = fatoresClimaticosDTO.Humidade,
                IndicePluviometrico = fatoresClimaticosDTO.IndicePluviometrico,
                Data = fatoresClimaticosDTO.Data,
                Id = fatoresClimaticosDTO.FatoresId,
            };
        }
    }
}

