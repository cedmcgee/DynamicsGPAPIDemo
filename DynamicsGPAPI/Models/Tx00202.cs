using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Tx00202
    {
        public string Taxdtlid { get; set; }
        public decimal Tdtsytd { get; set; }
        public decimal Tdsllytd { get; set; }
        public decimal Txdtsytd { get; set; }
        public decimal Tdtslytd { get; set; }
        public decimal Txdstytd { get; set; }
        public decimal Tdstlytd { get; set; }
        public byte Kpcalhst { get; set; }
        public byte Kperhist { get; set; }
        public int DexRowId { get; set; }
    }
}
