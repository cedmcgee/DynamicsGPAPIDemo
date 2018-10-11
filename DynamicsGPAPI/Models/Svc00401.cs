using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00401
    {
        public string Confgref { get; set; }
        public short Cnfglvl { get; set; }
        public short Cnfgseq { get; set; }
        public int Equipid { get; set; }
        public decimal Quantity { get; set; }
        public string Itemnmbr { get; set; }
        public short Parlevel { get; set; }
        public short Parseq { get; set; }
        public DateTime Instdte { get; set; }
        public string Dscriptn { get; set; }
        public int DexRowId { get; set; }
    }
}
