using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag00310
    {
        public int AaMlqueryId { get; set; }
        public string AaMlquery { get; set; }
        public string AaMlqueryDescr { get; set; }
        public short AaLevelTimeSpread { get; set; }
        public short AaLevelCodeSpread { get; set; }
        public short AaCodeSpreadCol { get; set; }
        public byte AaInclBsaccts { get; set; }
        public byte AaInclPlaccts { get; set; }
        public byte AaInclUnitAccts { get; set; }
        public short AaMatchType { get; set; }
        public string AaCallMacro { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
