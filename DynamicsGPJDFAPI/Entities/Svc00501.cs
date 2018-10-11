using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00501
    {
        public string Itemnmbr { get; set; }
        public short Itemtype { get; set; }
        public string Itemdesc { get; set; }
        public string Itmshnam { get; set; }
        public short Itmtrkop { get; set; }
        public decimal Listprce { get; set; }
        public byte Rtrnable { get; set; }
        public byte Metered { get; set; }
        public short SvcDeltaType { get; set; }
        public DateTime Modifdt { get; set; }
        public int DexRowId { get; set; }
    }
}
