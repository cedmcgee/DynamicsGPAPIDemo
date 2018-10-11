using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Gl12001
    {
        public string Bachnumb { get; set; }
        public int Jrnentry { get; set; }
        public string Budgetid { get; set; }
        public short Year1 { get; set; }
        public DateTime Perioddt { get; set; }
        public short Periodid { get; set; }
        public int Actindx { get; set; }
        public decimal Budgetamt { get; set; }
        public decimal BudgerAdjustment { get; set; }
        public byte[] Gllinval { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
