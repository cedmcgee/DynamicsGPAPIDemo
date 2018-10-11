using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class See30303
    {
        public string Itemnmbr { get; set; }
        public int Seqnumbr { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime Glpostdt { get; set; }
        public string Docnumbr { get; set; }
        public short Doctype { get; set; }
        public string Locncode { get; set; }
        public string Rcptnmbr { get; set; }
        public int Rctseqnm { get; set; }
        public short Pchsrcty { get; set; }
        public short Qtytype { get; set; }
        public string Uofm { get; set; }
        public decimal TrxqtyinBase { get; set; }
        public decimal Trxqty { get; set; }
        public decimal Varianceqty { get; set; }
        public decimal Unitcost { get; set; }
        public decimal Extdcost { get; set; }
        public short Decplqty { get; set; }
        public short Decplcur { get; set; }
        public byte IsOverrideReceipt { get; set; }
        public byte IsOverrideRelieved { get; set; }
        public DateTime OverrideRelievedDate { get; set; }
        public string Rcptnmbr1 { get; set; }
        public string Hstmodul { get; set; }
        public string Ortrxsrc { get; set; }
        public decimal Lnseqnbr { get; set; }
        public int Lnitmseq { get; set; }
        public int Cmpntseq { get; set; }
        public string Srcrfrncnmbr { get; set; }
        public string Vendorid { get; set; }
        public string Ponumber { get; set; }
        public short Trxreference { get; set; }
        public short Vctnmthd { get; set; }
        public int Ivivindx { get; set; }
        public int Ivivofix { get; set; }
        public int Jrnentry { get; set; }
        public string Trxsorce { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public int DexRowId { get; set; }
    }
}
