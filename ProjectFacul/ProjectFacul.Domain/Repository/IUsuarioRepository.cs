using ProjectFacul.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ProjectFacul.Domain.Repository
{
    public interface IUsuarioRepository
    {
        public List<Usuario> ListarTodos();
        public Usuario Selecionar(Guid idUsuario);
        public Usuario Adicionar(Usuario usuario);
        public Usuario Alterar(Usuario usuario);
        public Usuario Deletar(Guid idUsuario);
    }
}
