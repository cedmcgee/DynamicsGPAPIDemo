using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sop40701
    {
        public string Userid { get; set; }
        public string Prcbkid { get; set; }
        public string Itemnmbr { get; set; }
        public string Itemdesc { get; set; }
        public short Decplcur { get; set; }
        public short Decplqty { get; set; }
        public string Uofm { get; set; }
        public decimal Qtyfrom { get; set; }
        public decimal Qtyto { get; set; }
        public decimal Umqtyinb { get; set; }
        public decimal Unitprce { get; set; }
        public string Curncyid { get; set; }
        public string Ermsgtxt { get; set; }
        public int DexRowId { get; set; }
    }
}
