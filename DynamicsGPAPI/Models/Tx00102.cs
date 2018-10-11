using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Tx00102
    {
        public string Taxschid { get; set; }
        public string Taxdtlid { get; set; }
        public short Txdtlbse { get; set; }
        public byte Tdtaxtax { get; set; }
        public byte AutoCalculate { get; set; }
        public int DexRowId { get; set; }
    }
}
