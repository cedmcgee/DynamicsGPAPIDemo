using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag30001
    {
        public int AaGlhdrId { get; set; }
        public int AaGldistId { get; set; }
        public string Interid { get; set; }
        public string CorrespondingUnit { get; set; }
        public int Actindx { get; set; }
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
        public string AaCustId { get; set; }
        public string AaVendId { get; set; }
        public string AaSiteId { get; set; }
        public string AaItemId { get; set; }
        public string Employid { get; set; }
        public string AaAssetId { get; set; }
        public string AaBookId { get; set; }
        public short AaCopyStatus { get; set; }
        public string Sourcdoc { get; set; }
        public DateTime AaChangeDate { get; set; }
        public DateTime AaChangeTime { get; set; }
        public byte AaClStatus { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
