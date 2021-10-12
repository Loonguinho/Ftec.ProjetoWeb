using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectFacul.Models
{
    public class FatoresClimaticosModel
    {
        public Guid id { get; set; }
        public int temperatura { get; set; }

        public int humidade { get; set; }

        public int chuvas { get; set; }
    }
}
