using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag20001
    {
        public int AaSubLedgerHdrId { get; set; }
        public int AaSubLedgerDistId { get; set; }
        public string Interid { get; set; }
        public string CorrespondingUnit { get; set; }
        public int Actindx { get; set; }
        public short Disttype { get; set; }
        public short Accttype { get; set; }
        public short AaBrowseType { get; set; }
        public short Decplacs { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Ordbtamt { get; set; }
        public decimal Orcrdamt { get; set; }
        public string Curncyid { get; set; }
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; }
        public string Exgtblid { get; set; }
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public int Seqnumbr { get; set; }
        public DateTime Glpostdt { get; set; }
        public string AaCustId { get; set; }
        public string AaVendId { get; set; }
        public string AaSiteId { get; set; }
        public string AaItemId { get; set; }
        public string Employid { get; set; }
        public string AaAssetId { get; set; }
        public string AaBookId { get; set; }
        public short AaCopyStatus { get; set; }
        public byte AaWinWasOpen { get; set; }
        public byte Posted { get; set; }
        public byte History { get; set; }
        public byte[] AaDistErrors { get; set; }
        public string Aptvchnm { get; set; }
        public short Aptodcty { get; set; }
        public int AaFutureDist { get; set; }
        public byte AaOffsetAcct { get; set; }
        public string Itemnmbr { get; set; }
        public string Trxloctn { get; set; }
        public string Binnmbr { get; set; }
        public string Trnstloc { get; set; }
        public decimal Trxqty { get; set; }
        public short Pyrlrtyp { get; set; }
        public int Trxnumber { get; set; }
        public DateTime AaChangeDate { get; set; }
        public DateTime AaChangeTime { get; set; }
        public int DexRowId { get; set; }
    }
}
