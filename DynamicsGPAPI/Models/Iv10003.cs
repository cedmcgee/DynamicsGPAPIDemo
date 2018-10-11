using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Iv10003
    {
        public string Ivdocnbr { get; set; }
        public short Ivdoctyp { get; set; }
        public decimal Lnseqnbr { get; set; }
        public int Seqnumbr { get; set; }
        public string Itemnmbr { get; set; }
        public string Locncode { get; set; }
        public string Bin { get; set; }
        public string Tobin { get; set; }
        public short Qtytype { get; set; }
        public decimal Quantity { get; set; }
        public decimal Qtyscrapped { get; set; }
        public int DexRowId { get; set; }
    }
}
