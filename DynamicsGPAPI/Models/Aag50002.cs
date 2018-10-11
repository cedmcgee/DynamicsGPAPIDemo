using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag50002
    {
        public string Userid { get; set; }
        public string Trxbtchsrc { get; set; }
        public int AaSubLedgerHdrId { get; set; }
        public int AaSubLedgerDistId { get; set; }
        public int AaSubLedgerAssignId { get; set; }
        public short Series { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Ordbtamt { get; set; }
        public decimal Orcrdamt { get; set; }
        public string DistRef { get; set; }
        public int DexRowId { get; set; }
    }
}
