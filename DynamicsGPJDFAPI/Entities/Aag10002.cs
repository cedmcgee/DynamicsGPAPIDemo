using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag10002
    {
        public int AaGlworkHdrId { get; set; }
        public int AaGlworkDistId { get; set; }
        public int AaGlworkAssignId { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Ordbtamt { get; set; }
        public decimal Orcrdamt { get; set; }
        public int AaAssignedPercent { get; set; }
        public string DistRef { get; set; }
        public decimal Noteindx { get; set; }
        public byte[] AaAssignErrors { get; set; }
        public int AaAliasId { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
