using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00303
    {
        public string Custnmbr { get; set; }
        public string Adrscode { get; set; }
        public int Equipid { get; set; }
        public string Serlnmbr { get; set; }
        public string Itemnmbr { get; set; }
        public string Itemdesc { get; set; }
        public DateTime Instdte { get; set; }
        public decimal Quantity { get; set; }
        public short Cnfglvl { get; set; }
        public short Cnfgseq { get; set; }
        public short Parlevel { get; set; }
        public short Parseq { get; set; }
        public byte Chdflag { get; set; }
        public int DexRowId { get; set; }
    }
}
