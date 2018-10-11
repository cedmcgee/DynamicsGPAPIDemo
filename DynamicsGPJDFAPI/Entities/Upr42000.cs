using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Upr42000
    {
        public string Statuscd { get; set; }
        public string Stsdescr { get; set; }
        public short Statustype { get; set; }
        public byte Inactive { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
