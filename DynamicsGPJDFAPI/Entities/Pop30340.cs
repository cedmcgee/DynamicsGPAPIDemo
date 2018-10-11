using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pop30340
    {
        public string Poprctnm { get; set; }
        public int Rcptlnnm { get; set; }
        public int Seqnumbr { get; set; }
        public string Itemnmbr { get; set; }
        public string Locncode { get; set; }
        public string Bin { get; set; }
        public short Qtytype { get; set; }
        public decimal Quantity { get; set; }
        public string Trxsorce { get; set; }
        public int DexRowId { get; set; }
    }
}
