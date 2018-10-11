using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sop50401
    {
        public string Itemnmbr { get; set; }
        public string Epitmtyp { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public string Prcshid { get; set; }
        public string Baseuofm { get; set; }
        public byte Active { get; set; }
        public string Prodtcod { get; set; }
        public decimal Qtyfrom { get; set; }
        public decimal Psitmval { get; set; }
        public string Freeitem { get; set; }
        public string Freeuofm { get; set; }
        public int DexRowId { get; set; }
    }
}
