using ProjectFacul.Application.Adapter;
using ProjectFacul.Application.DTO;
using ProjectFacul.Domain.Entities;
using ProjectFacul.Domain.Repository;
using System;
using System.Collections.Generic;

namespace ProjectFacul.Application
{
    public class FatoresClimaticosApplication
    {
        private IFatoresClimaticosRepository fatoresClimaticosRepository;

        public FatoresClimaticosApplication(IFatoresClimaticosRepository fatoresClimaticosRepository)
        {
            this.fatoresClimaticosRepository = fatoresClimaticosRepository;
        }

        public FatoresClimaticosApplication()
        {
        }

        public FatoresClimaticosDTO Selecionar(Guid idFatorClimatico)
        {
            var fatorClimatico = fatoresClimaticosRepository.Selecionar(idFatorClimatico);
            return FatoresClimaticosAdapter.ParaFatoresClimaticosDTO(fatorClimatico);
        }
        public Guid Inserir(FatoresClimaticosDTO fatorClimaticoDTO)
        {
            //Regra de negocio
            if(fatorClimaticoDTO.Humidade <= 0)
            {
                throw new ApplicationException("Humidade não pode ser igual a 0");
            }
            //insere o registro
            FatoresClimaticos fatores = FatoresClimaticosAdapter.ParaFatoresClimaticosDominio(fatorClimaticoDTO);
            fatores.Id = Guid.NewGuid();
            fatoresClimaticosRepository.Adicionar(fatores);
            return fatores.Id;
        }
        public Guid Alterar(FatoresClimaticosDTO fatorClimaticoDTO)
        {
            //Regra de negocio
            if (fatorClimaticoDTO.IndicePluviometrico <= 0)
            {
                throw new ApplicationException("Indice Pluviometrico não pode ser igual a 0");
            }
            //registro
            FatoresClimaticos fatores = FatoresClimaticosAdapter.ParaFatoresClimaticosDominio(fatorClimaticoDTO);
            fatoresClimaticosRepository.Alterar(fatores);
            return fatores.Id;
        }
        public void Excluir(Guid idFatorClimatico)
        {
            fatoresClimaticosRepository.Excluir(idFatorClimatico);
        }
        public List<FatoresClimaticosDTO> SelecionarTodos()
        {
            List<FatoresClimaticos> fatores = fatoresClimaticosRepository.ListarTodos();
            List<FatoresClimaticosDTO> fatoresDTO = new List<FatoresClimaticosDTO>();

            foreach(var fat in fatores)
            {
                fatoresDTO.Add(FatoresClimaticosAdapter.ParaFatoresClimaticosDTO(fat));
            }
            return fatoresDTO;
        }
    }
}
