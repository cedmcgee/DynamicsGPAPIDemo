using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc05612
    {
        public string RtvNumber { get; set; }
        public decimal RtvLine { get; set; }
        public int Seqnumbr { get; set; }
        public string Itemnmbr { get; set; }
        public string Loccodeb { get; set; }
        public string Locncode { get; set; }
        public string Bin { get; set; }
        public string Tobin { get; set; }
        public short Qtytype { get; set; }
        public decimal Quantity { get; set; }
        public byte Posted { get; set; }
        public int DexRowId { get; set; }
    }
}
