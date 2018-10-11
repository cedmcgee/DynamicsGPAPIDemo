using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag00905
    {
        public int AaBudgetId { get; set; }
        public int AaCodeSequence { get; set; }
        public int Actindx { get; set; }
        public DateTime Perioddt { get; set; }
        public short AaFiscalPeriod { get; set; }
        public int AaActualPriliminary { get; set; }
        public short AaRange { get; set; }
        public decimal Balance { get; set; }
        public short Year1 { get; set; }
        public int DexRowId { get; set; }
    }
}
