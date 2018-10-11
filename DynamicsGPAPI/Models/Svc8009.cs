using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc8009
    {
        public string Schedid { get; set; }
        public decimal Lnseqnbr { get; set; }
        public short Freqofpm { get; set; }
        public decimal Quantity { get; set; }
        public string Uofm { get; set; }
        public short SvcMeterType { get; set; }
        public short SvcPmType { get; set; }
        public string Pmdtlid { get; set; }
        public int DexRowId { get; set; }
    }
}
