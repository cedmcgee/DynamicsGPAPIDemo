using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00502
    {
        public string Itemnmbr { get; set; }
        public string Locncode { get; set; }
        public short Rcrdtype { get; set; }
        public decimal Qtyonhnd { get; set; }
        public decimal Atyalloc { get; set; }
        public short SvcDeltaType { get; set; }
        public DateTime Modifdt { get; set; }
        public int DexRowId { get; set; }
    }
}
