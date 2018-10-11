using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Iv30300
    {
        public string Trxsorce { get; set; }
        public short Doctype { get; set; }
        public string Docnumbr { get; set; }
        public DateTime Docdate { get; set; }
        public string Hstmodul { get; set; }
        public string Custnmbr { get; set; }
        public string Itemnmbr { get; set; }
        public decimal Lnseqnbr { get; set; }
        public string Uofm { get; set; }
        public decimal Trxqty { get; set; }
        public decimal Unitcost { get; set; }
        public decimal Extdcost { get; set; }
        public string Trxloctn { get; set; }
        public string Trnstloc { get; set; }
        public short Trfqtyty { get; set; }
        public short Trtqtyty { get; set; }
        public int Ivivindx { get; set; }
        public int Ivivofix { get; set; }
        public short Decplcur { get; set; }
        public short Decplqty { get; set; }
        public decimal Qtybsuom { get; set; }
        public string ReasonCode { get; set; }
        public int DexRowId { get; set; }
    }
}
