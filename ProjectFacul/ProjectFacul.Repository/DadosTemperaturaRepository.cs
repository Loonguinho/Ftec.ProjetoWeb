using System;
using System.Collections.Generic;

namespace ProjectFacul.ProjetoWeb.Api.Model
{
    public class DadosTemperaturaRepository : IDadosTemperaturaRepository
    {
        public int Temperatura { get; set; }
        public DateTime dataHora { get; set; }
    }
}
