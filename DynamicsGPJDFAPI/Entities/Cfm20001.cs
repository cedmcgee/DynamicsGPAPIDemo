using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Cfm20001
    {
        public int Seqnumbr { get; set; }
        public DateTime Duedate { get; set; }
        public string Dscriptn { get; set; }
        public decimal CfmAmount { get; set; }
        public int DexRowId { get; set; }
    }
}
