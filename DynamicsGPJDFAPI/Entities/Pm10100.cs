using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pm10100
    {
        public string Vchrnmbr { get; set; }
        public int Dstsqnum { get; set; }
        public short Cntrltyp { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Debitamt { get; set; }
        public int Dstindx { get; set; }
        public short Disttype { get; set; }
        public byte Changed { get; set; }
        public string Userid { get; set; }
        public short Pstgstus { get; set; }
        public string Vendorid { get; set; }
        public string Trxsorce { get; set; }
        public DateTime Pstgdate { get; set; }
        public string Interid { get; set; }
        public string Curncyid { get; set; }
        public short Currnidx { get; set; }
        public decimal Orcrdamt { get; set; }
        public decimal Ordbtamt { get; set; }
        public string Aptvchnm { get; set; }
        public short Aptodcty { get; set; }
        public short Spcldist { get; set; }
        public string DistRef { get; set; }
        public string Ratetpid { get; set; }
        public string Exgtblid { get; set; }
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public short Decplacs { get; set; }
        public DateTime Expndate { get; set; }
        public string Iccurrid { get; set; }
        public short Iccurrix { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public string CorrespondingUnit { get; set; }
        public int DexRowId { get; set; }
    }
}
