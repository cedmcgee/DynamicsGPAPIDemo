using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag50001
    {
        public string Userid { get; set; }
        public string Trxbtchsrc { get; set; }
        public short Series { get; set; }
        public int AaSubLedgerHdrId { get; set; }
        public int AaSubLedgerDistId { get; set; }
        public int Actindx { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Ordbtamt { get; set; }
        public decimal Orcrdamt { get; set; }
        public string Curncyid { get; set; }
        public short Currnidx { get; set; }
        public byte Posted { get; set; }
        public int DexRowId { get; set; }
    }
}
