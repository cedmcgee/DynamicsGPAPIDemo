using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Cam40001
    {
        public short Sgmtnumb { get; set; }
        public short CamSeries { get; set; }
        public byte Camactivated { get; set; }
        public byte CamDistributionCreated { get; set; }
        public byte CamPosted { get; set; }
        public string Bachnumb { get; set; }
        public string Bchcomnt { get; set; }
        public string Refrence { get; set; }
        public string Trxsrcpx { get; set; }
        public string Sourcdoc { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
