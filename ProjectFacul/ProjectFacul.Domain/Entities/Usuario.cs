using System;

namespace ProjectFacul.Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Genero { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
