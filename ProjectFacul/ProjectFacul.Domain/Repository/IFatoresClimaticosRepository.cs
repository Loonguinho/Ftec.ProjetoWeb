using ProjectFacul.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFacul.Domain.Repository
{
    public interface IFatoresClimaticosRepository
    {
        public List<FatoresClimaticos> ListarTodos();
        public FatoresClimaticos Selecionar(Guid idFatoresClimaticos);
        public void Adicionar(FatoresClimaticos fatoresClimaticos);
        public void Alterar(FatoresClimaticos fatoresClimaticos);
        public void Excluir(Guid idFatoresClimaticos);
    }
}
