using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc05001
    {
        public short ReturnRecordType { get; set; }
        public string Retdocid { get; set; }
        public decimal Lnseqnbr { get; set; }
        public string Linitmtyp { get; set; }
        public int Lnitmseq { get; set; }
        public string Itemnmbr { get; set; }
        public string Itemdesc { get; set; }
        public string Serlnmbr { get; set; }
        public decimal Quantity { get; set; }
        public byte Received { get; set; }
        public byte Shipped { get; set; }
        public int DexRowId { get; set; }
    }
}
