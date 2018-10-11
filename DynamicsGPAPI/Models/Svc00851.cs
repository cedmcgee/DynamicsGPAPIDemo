using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00851
    {
        public string EcoNumber { get; set; }
        public int Lnitmseq { get; set; }
        public short Rcrdtype { get; set; }
        public string Itemnmbr { get; set; }
        public decimal Quantity { get; set; }
        public string Uofm { get; set; }
        public string Uomschdl { get; set; }
        public decimal Unitcost { get; set; }
        public decimal Unitprce { get; set; }
        public decimal Extdcost { get; set; }
        public decimal Xtndprce { get; set; }
        public int DexRowId { get; set; }
    }
}
