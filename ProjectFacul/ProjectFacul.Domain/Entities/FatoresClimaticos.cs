
using System;

namespace ProjectFacul.Domain.Entities
{
    public class FatoresClimaticos
    {
        public Guid Id { get; set; }
        public int Humidade { get; set; }
        public int Temperatura { get; set; }
        public decimal IndicePluviometrico { get; set; }
        public DateTime Data { get; set; }
        public Praga Praga { get; set; }

        public FatoresClimaticos()
        {
            Praga = new Praga();
            Id = Guid.NewGuid();
        }
    }
}
