using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pt10000
    {
        public string Projname { get; set; }
        public string Itemnmbr { get; set; }
        public string Itemdesc { get; set; }
        public short Noninven { get; set; }
        public short ProjDistDocSource { get; set; }
        public string Docnumbr { get; set; }
        public int Lnitmseq { get; set; }
        public int Cmpntseq { get; set; }
        public int Dstsqnum { get; set; }
        public DateTime Docdate { get; set; }
        public string Whom { get; set; }
        public short ProjDistType { get; set; }
        public short ProDistCategory { get; set; }
        public short Incordec { get; set; }
        public decimal Distamnt { get; set; }
        public decimal Quantity { get; set; }
        public short BillableType { get; set; }
        public short Decplqty { get; set; }
        public short Decplcur { get; set; }
        public byte Posted { get; set; }
        public short ProjDistBillStatus { get; set; }
        public string PayCode { get; set; }
        public decimal Payrate { get; set; }
        public string Sopnumbe { get; set; }
        public int DexRowId { get; set; }
    }
}
