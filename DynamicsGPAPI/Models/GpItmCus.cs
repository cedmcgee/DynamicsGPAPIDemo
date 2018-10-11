using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class GpItmCus
    {
        public string Custnmbr { get; set; }
        public string Itemnmbr { get; set; }
        public string Itemdesc { get; set; }
        public DateTime Docdate { get; set; }
        public decimal Qtytoinv { get; set; }
        public string Uofm { get; set; }
        public decimal Unitprce { get; set; }
        public string Sopnumbe { get; set; }
        public short Soptype { get; set; }
        public int Lnitmseq { get; set; }
        public short Decplqty { get; set; }
        public short Decplcur { get; set; }
        public int DexRowId { get; set; }
    }
}
