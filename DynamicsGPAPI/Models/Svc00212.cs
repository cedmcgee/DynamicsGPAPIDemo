using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00212
    {
        public short Srvrectype { get; set; }
        public string Callnbr { get; set; }
        public int Eqpline { get; set; }
        public string Linitmtyp { get; set; }
        public int Lnitmseq { get; set; }
        public int Seqnumbr { get; set; }
        public string Itemnmbr { get; set; }
        public string Locncode { get; set; }
        public string Bin { get; set; }
        public short Qtytype { get; set; }
        public decimal Quantity { get; set; }
        public byte Posted { get; set; }
        public byte Mkdtopst { get; set; }
        public int Cmpntseq { get; set; }
        public int DexRowId { get; set; }
    }
}
