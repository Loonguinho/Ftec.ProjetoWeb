using System;

namespace ProjectFacul.Application.DTO
{
    public class FatoresClimaticos
    {
        public Guid id { get; set; }
        public int Temperatura { get; set; }
        public int Humidade { get; set; }
        public int IndicePluviometrico { get; set; }
    }
}
