using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00712
    {
        public string Orddocid { get; set; }
        public int Lnitmseq { get; set; }
        public int Seqnumbr { get; set; }
        public string Itemnmbr { get; set; }
        public string Trnsfloc { get; set; }
        public string Locncode { get; set; }
        public string Bin { get; set; }
        public string Tobin { get; set; }
        public short Qtytype { get; set; }
        public decimal Quantity { get; set; }
        public byte Posted { get; set; }
        public int DexRowId { get; set; }
    }
}
