using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc8001
    {
        public string Pmdtlid { get; set; }
        public short Rcrdtype { get; set; }
        public decimal Lnseqnbr { get; set; }
        public string Itemnmbr { get; set; }
        public decimal Quantity { get; set; }
        public string Uofm { get; set; }
        public decimal Unitprce { get; set; }
        public decimal Xtndprce { get; set; }
        public decimal Unitcost { get; set; }
        public decimal Extdcost { get; set; }
        public int DexRowId { get; set; }
    }
}
