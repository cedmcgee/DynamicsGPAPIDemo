using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag20003
    {
        public int AaSubLedgerHdrId { get; set; }
        public int AaSubLedgerDistId { get; set; }
        public int AaSubLedgerAssignId { get; set; }
        public int AaTrxDimId { get; set; }
        public int AaTrxCodeId { get; set; }
        public byte[] AaCodeErrors { get; set; }
        public int DexRowId { get; set; }
    }
}
