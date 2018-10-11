using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Fa00500
    {
        public int Assetindex { get; set; }
        public int Leasecompindx { get; set; }
        public short Leasetype { get; set; }
        public string Leasecontractid { get; set; }
        public decimal Leasepayment { get; set; }
        public short Leaseintrate { get; set; }
        public DateTime Leaseenddate { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; }
        public int DexRowId { get; set; }
    }
}
