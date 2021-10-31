using System;

namespace ProjectFacul.ProjetoWeb.Api.Model
{
    public class FatoresClimaticos
    {
        public Guid id { get; set; }
        public int Temperatura { get; set; }
        public string Humidade { get; set; }
        public string IndicePluviometrico { get; set; }
        public DateTime Data { get; set; }
    }
}
