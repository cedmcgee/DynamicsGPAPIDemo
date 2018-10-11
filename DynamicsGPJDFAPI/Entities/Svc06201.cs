using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc06201
    {
        public string Servicebom { get; set; }
        public decimal Sequence1 { get; set; }
        public string Itemnmbr { get; set; }
        public string Itemdesc { get; set; }
        public decimal Quantity { get; set; }
        public DateTime Effdate { get; set; }
        public DateTime Expndate { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
