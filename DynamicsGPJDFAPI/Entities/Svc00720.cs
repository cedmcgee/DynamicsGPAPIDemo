using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00720
    {
        public string Userid { get; set; }
        public string SvcTechInventoryId { get; set; }
        public string Itemnmbr { get; set; }
        public int Lnitmseq { get; set; }
        public string Locncode { get; set; }
        public string Uofm { get; set; }
        public decimal QtyRequired { get; set; }
        public decimal Qtyonhnd { get; set; }
        public decimal Trxqty { get; set; }
        public int DexRowId { get; set; }
    }
}
