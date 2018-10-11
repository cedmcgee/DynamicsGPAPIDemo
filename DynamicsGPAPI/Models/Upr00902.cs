using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Upr00902
    {
        public string Employid { get; set; }
        public short Year1 { get; set; }
        public short Periodid { get; set; }
        public string Lpchknum { get; set; }
        public DateTime Lstpckdt { get; set; }
        public decimal Lpchkamt { get; set; }
        public decimal GrossWagesFiscal { get; set; }
        public decimal FederalWithholdingFisc { get; set; }
        public decimal FicassWagesFiscal { get; set; }
        public decimal FicamedWagesFiscal { get; set; }
        public decimal FicassWithholdingFisca { get; set; }
        public decimal FicamedWithholdingFisc { get; set; }
        public decimal SutaWagesFiscal { get; set; }
        public decimal FutaWagesFiscal { get; set; }
        public decimal NetWagesFiscal { get; set; }
        public decimal FederalWagesFiscal { get; set; }
        public int DexRowId { get; set; }
    }
}
