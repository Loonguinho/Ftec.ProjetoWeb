using ProjectFacul.Application.Adapter;
using ProjectFacul.Application.DTO;
using ProjectFacul.Domain.Entities;
using ProjectFacul.Domain.Repository;
using System;
using System.Collections.Generic;

namespace ProjectFacul.Application
{
    public class UsuarioApplication
    {
        private IUsuarioRepository usuarioRepository;

        public UsuarioApplication(IUsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }

        
        public UsuarioDTO Selecionar(Guid idUsuario)
        {
            var usuario = usuarioRepository.Selecionar(idUsuario);

            return UsuarioAdapter.ParaUsuarioDTO(usuario);
        }

        public Guid Adicionar(UsuarioDTO usuarioDto)
        {
            //Regra de negocio
            
            if (string.IsNullOrEmpty(usuarioDto.Nome))
            {
                throw new ApplicationException();
            }

            //insere o registro
            Usuario user = UsuarioAdapter.ParaUsuarioDominio(usuarioDto);
            usuarioRepository.Adicionar(user);
            return user.Id;
            
        }

        public Guid Alterar(UsuarioDTO usuarioDto)
        {
            //Regra de negocio

            if (string.IsNullOrEmpty(usuarioDto.Nome))
            {
                throw new ApplicationException();
            }

            //insere o registro
            Usuario user = UsuarioAdapter.ParaUsuarioDominio(usuarioDto);
            usuarioRepository.Adicionar(user);
            return user.Id;
        }

        public void Deletar(Guid idUsuario)
        {
            usuarioRepository.Deletar(idUsuario);
        }

        public List<UsuarioDTO> SelecionarTodos()
        {
            List<Usuario> usuarios = usuarioRepository.ListarTodos();
            List<UsuarioDTO> usuariosDTO = new List<UsuarioDTO>();

            foreach (var user in usuarios)
            {
                usuariosDTO.Add(UsuarioAdapter.ParaUsuarioDTO(user));
            }

            return usuariosDTO;
        }

    }
}
