using System;

namespace ProjectFacul.Application.DTO
{
    public class FatoresClimaticosDTO
    {
        public Guid Id { get; set; }
        public int Temperatura { get; set; }
        public int Humidade { get; set; }
        public decimal IndicePluviometrico { get; set; }
        public DateTime Data { get; set; }
    }
}
