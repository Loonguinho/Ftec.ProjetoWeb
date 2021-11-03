
using ProjectFacul.Application.DTO;
using ProjectFacul.Domain.Entities;

namespace ProjectFacul.Application.Adapter
{
    public class UsuarioAdapter
    {
        public static UsuarioDTO ParaUsuarioDTO(Usuario usuario)
        {
            return new UsuarioDTO()
            {
                DataNascimento = usuario.DataNascimento,
                Genero = usuario.Genero,
                Idade = usuario.Idade,
                Nome = usuario.Nome,
                Id = usuario.Id
            };
        }
        public static Usuario ParaUsuarioDominio(UsuarioDTO usuarioDto)
        {
            return new Usuario()
            {
                DataNascimento = usuarioDto.DataNascimento,
                Genero = usuarioDto.Genero,
                Idade = usuarioDto.Idade,
                Nome = usuarioDto.Nome,
                Id = usuarioDto.Id
            };
        }
    }
}
