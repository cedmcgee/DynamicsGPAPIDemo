using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc05212
    {
        public short ReturnRecordType { get; set; }
        public string Retdocid { get; set; }
        public decimal Lnseqnbr { get; set; }
        public int Seqnumbr { get; set; }
        public string Itemnmbr { get; set; }
        public string Locncode { get; set; }
        public string Bin { get; set; }
        public short Qtytype { get; set; }
        public decimal Quantity { get; set; }
        public byte Posted { get; set; }
        public int Cmpntseq { get; set; }
        public int DexRowId { get; set; }
    }
}
