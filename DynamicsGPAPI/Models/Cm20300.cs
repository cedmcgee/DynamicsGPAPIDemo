using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Cm20300
    {
        public decimal Cmrecnum { get; set; }
        public string SRecNum { get; set; }
        public short Cntrltyp { get; set; }
        public byte Deposited { get; set; }
        public string Mdfusrid { get; set; }
        public DateTime Modifdt { get; set; }
        public string Chekbkid { get; set; }
        public string Depositnumber { get; set; }
        public string Rcptnmbr { get; set; }
        public DateTime Receiptdate { get; set; }
        public decimal Rcptamt { get; set; }
        public short RcpType { get; set; }
        public string Cardname { get; set; }
        public string Curncyid { get; set; }
        public string Bankname { get; set; }
        public string Bnkbrnch { get; set; }
        public DateTime Glpostdt { get; set; }
        public DateTime Posteddt { get; set; }
        public string Ptdusrid { get; set; }
        public string CmlinkId { get; set; }
        public string RcvdFrom { get; set; }
        public string Dscriptn { get; set; }
        public byte Voided { get; set; }
        public DateTime Voiddate { get; set; }
        public DateTime Voidpdate { get; set; }
        public string Voiddesc { get; set; }
        public string Userdef1 { get; set; }
        public string Userdef2 { get; set; }
        public decimal Noteindx { get; set; }
        public short Rcrdstts { get; set; }
        public string Sourcdoc { get; set; }
        public string Srcdocnum { get; set; }
        public short Srcdoctyp { get; set; }
        public string Audittrail { get; set; }
        public decimal Origamt { get; set; }
        public decimal CheckbookAmount { get; set; }
        public string Ratetpid { get; set; }
        public string Rcvgratetpid { get; set; }
        public string Exgtblid { get; set; }
        public decimal Xchgrate { get; set; }
        public decimal ReceivingExchangeRate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public short Rcvgrtclcmtd { get; set; }
        public DateTime Expndate { get; set; }
        public short Currnidx { get; set; }
        public short Decplcur { get; set; }
        public decimal Rlganlos { get; set; }
        public int CashAccountIndex { get; set; }
        public int RealizedGlAccountInde { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public decimal ReceivingDenomExrate { get; set; }
        public short ReceivingMcTransaction { get; set; }
        public string Pmntnmbr { get; set; }
        public byte Eftflag { get; set; }
        public int DexRowId { get; set; }
    }
}
