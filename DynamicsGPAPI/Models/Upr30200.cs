using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Upr30200
    {
        public string Auctrlcd { get; set; }
        public DateTime Chekdate { get; set; }
        public decimal Ftxwhlty { get; set; }
        public decimal Ficasstl { get; set; }
        public decimal Ficamtwl { get; set; }
        public decimal UncollectedFicassTaxP { get; set; }
        public decimal UncollectedFicamedTaxP { get; set; }
        public decimal Adeicpmt { get; set; }
        public decimal Eficasstl { get; set; }
        public decimal Eficamtwl { get; set; }
        public int DexRowId { get; set; }
    }
}
