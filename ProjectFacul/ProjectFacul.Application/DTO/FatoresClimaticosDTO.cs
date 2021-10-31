using System;

namespace ProjectFacul.Application.DTO
{
    public class FatoresClimaticos
    {
        public Guid FatoresId { get; set; }
        public int Temperatura { get; set; }
        public string Humidade { get; set; }
        public string IndicePluviometrico { get; set; }
        public DateTime Data { get; set; }
        public Guid Id { get; internal set; }
    }
}
