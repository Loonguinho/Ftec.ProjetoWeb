using ProjectFacul.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ProjectFacul.Domain.Repository
{
    public interface IUsuarioRepository
    {
        public List<Usuarios> ListarTodos();
        public Usuarios Autenticar(string usuario);
        public Usuarios Adicionar(Usuarios usuario);
        public Usuarios Alterar(Usuarios usuario);
        public Usuarios Deletar(Guid idUsuario);
    }
}
