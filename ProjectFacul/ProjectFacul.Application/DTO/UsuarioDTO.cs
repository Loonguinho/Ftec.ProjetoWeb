using System;

namespace ProjectFacul.Application.DTO
{
    public class UsuarioDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Genero { get; set; }
        public DateTime DataNascimento { get; set; }

        public string Usuario { get; set; }
        public string Senha { get; set; }
    }
}
