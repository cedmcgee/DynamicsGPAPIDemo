using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pop10170
    {
        public string Ponumber { get; set; }
        public string Pmntnmbr { get; set; }
        public short PrepaymentSource { get; set; }
        public short Pyenttyp { get; set; }
        public decimal PrepaymentAmount { get; set; }
        public decimal OriginatingPrepaymentAmt { get; set; }
        public decimal Appldamt { get; set; }
        public decimal Orappamt { get; set; }
        public decimal Curtrxam { get; set; }
        public decimal Orctrxam { get; set; }
        public decimal Distknam { get; set; }
        public decimal Ordistkn { get; set; }
        public string Chekbkid { get; set; }
        public string Cardname { get; set; }
        public string Cheknmbr { get; set; }
        public string Docnumbr { get; set; }
        public short Cntrltyp { get; set; }
        public int PrepaymentAccountIndex { get; set; }
        public int CashAccountIndex { get; set; }
        public int PayAcctIdx { get; set; }
        public DateTime Glpostdt { get; set; }
        public string Bachnumb { get; set; }
        public string Bchsourc { get; set; }
        public string Trxsorce { get; set; }
        public short Pstgstus { get; set; }
        public byte Voided { get; set; }
        public string Curncyid { get; set; }
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; }
        public string Exgtblid { get; set; }
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Ratecalc { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public int DexRowId { get; set; }
    }
}
