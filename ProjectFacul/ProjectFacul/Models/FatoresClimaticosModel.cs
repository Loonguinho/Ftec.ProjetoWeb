using System;

namespace ProjectFacul.Models
{
    public class FatoresClimaticosModel
    {
        public Guid Id { get; set; }
        public int Temperatura { get; set; }
        public int Humidade { get; set; }
        public int IndicePluviometrico { get; set; }
        public DateTime Data { get; set; }
    }
}
