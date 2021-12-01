using System;

namespace ProjectFacul.ProjetoWeb.Api.Model
{
    public class DadosHumidade
    {
        public Guid Id { get; set; }
        public int Humidade { get; set; }
        public DateTime Data { get; set; }
    }
}
