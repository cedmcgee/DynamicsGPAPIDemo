using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag00300
    {
        public int AaDistrQueryId { get; set; }
        public string AaDistrQuery { get; set; }
        public string AaDistrQueryDescr { get; set; }
        public byte AaInclBsaccts { get; set; }
        public byte AaInclPlaccts { get; set; }
        public byte AaInclUnitAccts { get; set; }
        public string AaCallMacro { get; set; }
        public short AaMatchType { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
