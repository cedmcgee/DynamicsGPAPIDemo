using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pm30600
    {
        public short Doctype { get; set; }
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
        public string Curncyid { get; set; }
        public short Currnidx { get; set; }
        public decimal Orcrdamt { get; set; }
        public decimal Ordbtamt { get; set; }
        public string Aptvchnm { get; set; }
        public short Aptodcty { get; set; }
        public short Spcldist { get; set; }
        public string DistRef { get; set; }
        public int DexRowId { get; set; }
    }
}
