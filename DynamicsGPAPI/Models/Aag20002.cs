using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag20002
    {
        public int AaSubLedgerHdrId { get; set; }
        public int AaSubLedgerDistId { get; set; }
        public int AaSubLedgerAssignId { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Ordbtamt { get; set; }
        public decimal Orcrdamt { get; set; }
        public int AaAssignedPercent { get; set; }
        public string DistRef { get; set; }
        public decimal Noteindx { get; set; }
        public byte[] AaAssignErrors { get; set; }
        public int AaAliasId { get; set; }
        public int DexRowId { get; set; }
    }
}
