using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag40000
    {
        public int AaGlhdrId { get; set; }
        public int Jrnentry { get; set; }
        public decimal Rctrxseq { get; set; }
        public short Year1 { get; set; }
        public short AaTrxtype { get; set; }
        public string AaGltrxsource { get; set; }
        public string AaTrxsource { get; set; }
        public DateTime Glpostdt { get; set; }
        public short LedgerId { get; set; }
        public int DexRowId { get; set; }
    }
}
