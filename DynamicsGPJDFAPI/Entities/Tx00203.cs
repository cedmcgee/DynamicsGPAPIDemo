using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Tx00203
    {
        public short Histtype { get; set; }
        public short Year1 { get; set; }
        public short Periodid { get; set; }
        public string Taxdtlid { get; set; }
        public decimal Tdtslpch { get; set; }
        public decimal Txdttxsp { get; set; }
        public decimal Txdtsptx { get; set; }
        public int DexRowId { get; set; }
    }
}
