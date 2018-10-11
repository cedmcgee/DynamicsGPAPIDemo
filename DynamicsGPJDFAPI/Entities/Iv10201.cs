using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Iv10201
    {
        public string Itemnmbr { get; set; }
        public string Trxloctn { get; set; }
        public short Qtytype { get; set; }
        public DateTime Docdate { get; set; }
        public int Rctseqnm { get; set; }
        public short Origindoctype { get; set; }
        public string Origindocid { get; set; }
        public decimal Lnseqnbr { get; set; }
        public int Cmpntseq { get; set; }
        public decimal Qtysold { get; set; }
        public decimal Unitcost { get; set; }
        public int Ivivindx { get; set; }
        public int Ivivofix { get; set; }
        public int Srcrctseqnm { get; set; }
        public short Trxreference { get; set; }
        public short Pchsrcty { get; set; }
        public int DexRowId { get; set; }
    }
}
