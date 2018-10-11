using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Cm20200
    {
        public decimal Cmrecnum { get; set; }
        public string SRecNum { get; set; }
        public short Rcrdstts { get; set; }
        public string Chekbkid { get; set; }
        public string CmtrxNum { get; set; }
        public short CmtrxType { get; set; }
        public DateTime Trxdate { get; set; }
        public DateTime Glpostdt { get; set; }
        public decimal Trxamnt { get; set; }
        public string Curncyid { get; set; }
        public string CmlinkId { get; set; }
        public string Paidtorcvdfrom { get; set; }
        public string Dscriptn { get; set; }
        public byte Recond { get; set; }
        public decimal Reconum { get; set; }
        public decimal ClrdAmt { get; set; }
        public DateTime Clearedate { get; set; }
        public byte Voided { get; set; }
        public DateTime Voiddate { get; set; }
        public DateTime Voidpdate { get; set; }
        public string Voiddesc { get; set; }
        public decimal Noteindx { get; set; }
        public string Audittrail { get; set; }
        public short Deptype { get; set; }
        public string Sourcdoc { get; set; }
        public short Srcdoctyp { get; set; }
        public string Srcdocnum { get; set; }
        public DateTime Posteddt { get; set; }
        public string Ptdusrid { get; set; }
        public DateTime Modifdt { get; set; }
        public string Mdfusrid { get; set; }
        public string Userdef1 { get; set; }
        public string Userdef2 { get; set; }
        public decimal Origamt { get; set; }
        public decimal CheckbookAmount { get; set; }
        public string Ratetpid { get; set; }
        public string Exgtblid { get; set; }
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public DateTime Expndate { get; set; }
        public short Currnidx { get; set; }
        public short Decplcur { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public decimal XfrRecordNumber { get; set; }
        public byte Eftflag { get; set; }
        public int DexRowId { get; set; }
    }
}
