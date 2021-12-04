using System;

namespace ProjectFacul.ProjetoWeb.Api.Model
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Genero { get; set; }
        public DateTime DataNascimento { get; set; }

        public string Senha { get; set; }
        public string Usuario_ { get; set; }
        public object Token { get; set; }
    }
}
