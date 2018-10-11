using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag40002
    {
        public int AaGlhdrId { get; set; }
        public int AaGldistId { get; set; }
        public int AaGlassignId { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Ordbtamt { get; set; }
        public decimal Orcrdamt { get; set; }
        public int AaAssignedPercent { get; set; }
        public string DistRef { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
