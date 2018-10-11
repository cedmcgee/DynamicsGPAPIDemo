using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class If000001
    {
        public string Uniqkey { get; set; }
        public byte IfActivated { get; set; }
        public byte IfDistributionCreated { get; set; }
        public short IfMethod { get; set; }
        public short Sgmtnumb { get; set; }
        public string Sgmntid { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
