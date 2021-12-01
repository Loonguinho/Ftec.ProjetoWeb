using System;

namespace ProjectFacul.ProjetoWeb.Api.Model
{
    public class DadosPluviometricosRepository : IDadosPluviometricosRepository
    {
        public decimal IndicePluviometrico { get; set; }
        public DateTime Data { get; set; }
    }
}
