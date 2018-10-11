using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pm10801
    {
        public string Pmntnmbr { get; set; }
        public int Seqnumbr { get; set; }
        public int Dstsqnum { get; set; }
        public decimal DiscTknTot { get; set; }
        public decimal NetCkAmt { get; set; }
        public decimal PdTot { get; set; }
        public decimal NegTot { get; set; }
        public decimal CrdDocAmt { get; set; }
        public decimal TotDocAmt { get; set; }
        public decimal WrOffTot { get; set; }
        public string CrdtDesc { get; set; }
        public string Trxdscrn { get; set; }
        public byte PrtOnStb { get; set; }
        public string Aptvchnm { get; set; }
        public string Docnumbr { get; set; }
        public DateTime Docdate { get; set; }
        public decimal Amntpaid { get; set; }
        public decimal Crdtamnt { get; set; }
        public DateTime DocDueDate { get; set; }
        public decimal Docamnt { get; set; }
        public DateTime Discdate { get; set; }
        public decimal Distknam { get; set; }
        public decimal Wrofamnt { get; set; }
        public decimal Ppsamded { get; set; }
        public decimal Gstdsamt { get; set; }
        public string Apfvchnm { get; set; }
        public short Apfrdcty { get; set; }
        public short Aptodcty { get; set; }
        public string Curncyid { get; set; }
        public decimal OutstandingAmount { get; set; }
        public decimal NetPaidAmount { get; set; }
        public string Vchrnmbr { get; set; }
        public string Ponumber { get; set; }
        public int DexRowId { get; set; }
    }
}
