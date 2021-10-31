using System;

namespace ProjectFacul.Models
{
    public class FatoresClimaticosModel
    {
        public Guid FatoresId { get; set; }
        public int Temperatura { get; set; }
        public int Humidade { get; set; }
        public int IndicePluviometrico { get; set; }
    }
}
