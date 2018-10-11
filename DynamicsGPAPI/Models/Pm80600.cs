using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pm80600
    {
        public string Vchrnmbr { get; set; }
        public int Dstsqnum { get; set; }
        public short Cntrltyp { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Orcrdamt { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Ordbtamt { get; set; }
        public int Dstindx { get; set; }
        public short Disttype { get; set; }
        public string Userid { get; set; }
        public string Vendorid { get; set; }
        public string Trxsorce { get; set; }
        public DateTime Posteddt { get; set; }
        public short Doctype { get; set; }
        public DateTime Pstgdate { get; set; }
        public string Keysourc { get; set; }
        public short Aptodcty { get; set; }
        public string Aptvchnm { get; set; }
        public string Curncyid { get; set; }
        public short Currnidx { get; set; }
        public string Interid { get; set; }
        public byte Ictrx { get; set; }
        public string Iccurrid { get; set; }
        public short Iccurrix { get; set; }
        public int DexRowId { get; set; }
    }
}
