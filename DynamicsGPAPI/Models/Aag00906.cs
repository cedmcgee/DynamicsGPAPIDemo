using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag00906
    {
        public string Userid { get; set; }
        public short Wintype { get; set; }
        public short Cmpanyid { get; set; }
        public int AaBudgetId { get; set; }
        public int AaCodeSequence { get; set; }
        public int Actindx { get; set; }
        public int AaActualPriliminary { get; set; }
        public byte Netchng { get; set; }
        public short Year1 { get; set; }
        public short AaRange { get; set; }
        public byte AaAmtQty { get; set; }
        public string Str30 { get; set; }
        public string AaFromValue { get; set; }
        public string AaToValue { get; set; }
        public int AaRangeType { get; set; }
        public byte AaNodeCode { get; set; }
        public string ReportingLedgerNames { get; set; }
        public int DexRowId { get; set; }
    }
}
