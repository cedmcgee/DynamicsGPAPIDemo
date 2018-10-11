using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Det00100
    {
        public string Taxdtlid { get; set; }
        public string Txdtldsc { get; set; }
        public short Txdtltyp { get; set; }
        public short Txdtlbse { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public decimal Txdtlpct { get; set; }
        public decimal Txdtlamt { get; set; }
        public string TaxBaseDescription { get; set; }
        public int DexRowId { get; set; }
    }
}
