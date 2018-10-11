using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00921
    {
        public string Srvtype { get; set; }
        public int Lnitmseq { get; set; }
        public string Itemnmbr { get; set; }
        public string Itemdesc { get; set; }
        public decimal Quantity { get; set; }
        public decimal Listprce { get; set; }
        public decimal Costamnt { get; set; }
        public string Pricshed { get; set; }
        public byte Cblabor { get; set; }
        public byte Cbarts { get; set; }
        public byte Cbexp { get; set; }
        public byte Cbaddnl { get; set; }
        public string Dlrorpct { get; set; }
        public int DexRowId { get; set; }
    }
}
