using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag00605
    {
        public int AaTreeId { get; set; }
        public string AaTree { get; set; }
        public short AaLinkType { get; set; }
        public string AaDescr { get; set; }
        public int AaDimId { get; set; }
        public string AaTrxDim { get; set; }
        public string AaTreeDescr { get; set; }
        public byte AaTreeMain { get; set; }
        public byte AaTreeInclAllRec { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
