using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag00904
    {
        public int AaBudgetId { get; set; }
        public int AaCodeSequence { get; set; }
        public DateTime Perioddt { get; set; }
        public short AaFiscalPeriod { get; set; }
        public int AaActualPriliminary { get; set; }
        public decimal Balance { get; set; }
        public decimal Quantity { get; set; }
        public short Year1 { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
