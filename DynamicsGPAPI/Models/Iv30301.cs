using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Iv30301
    {
        public short Doctype { get; set; }
        public string Docnumbr { get; set; }
        public decimal Lnseqnbr { get; set; }
        public short Dtlseqnm { get; set; }
        public short Qtytype { get; set; }
        public string Rcptnmbr { get; set; }
        public decimal Rcptqty { get; set; }
        public decimal Rcptexct { get; set; }
        public int DexRowId { get; set; }
    }
}
