using System;

namespace ProjectFacul.Models
{
    public class UsuarioModel
    {
        public Guid UsuarioID { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Genero { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
