using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Iv40300
    {
        public string ReasonCode { get; set; }
        public string ReasonCodeDescription { get; set; }
        public byte Inactive { get; set; }
        public short TypesOfAdjVar { get; set; }
        public byte Adjustment { get; set; }
        public byte Variance { get; set; }
        public int Offindx { get; set; }
        public byte ItemTransfer { get; set; }
        public byte InTransitTransfer { get; set; }
        public byte ItemBinTransfer { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Creatddt { get; set; }
        public int DexRowId { get; set; }
    }
}
