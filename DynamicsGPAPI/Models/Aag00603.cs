using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag00603
    {
        public string Userid { get; set; }
        public int AaNodeId { get; set; }
        public string AaNode { get; set; }
        public int AaLevel { get; set; }
        public int AaParentNodeId { get; set; }
        public int AaOrder { get; set; }
        public decimal Noteindx { get; set; }
        public short Status { get; set; }
        public int DexRowId { get; set; }
    }
}
