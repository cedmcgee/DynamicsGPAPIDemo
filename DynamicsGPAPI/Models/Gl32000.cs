using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Gl32000
    {
        public int Jrnentry { get; set; }
        public string Budgetid { get; set; }
        public short Year1 { get; set; }
        public DateTime Perioddt { get; set; }
        public short Periodid { get; set; }
        public int Actindx { get; set; }
        public decimal Budgetamt { get; set; }
        public decimal BudgerAdjustment { get; set; }
        public string Refrence { get; set; }
        public DateTime Trxdate { get; set; }
        public string Sourcdoc { get; set; }
        public string Trxsorce { get; set; }
        public string Uswhpstd { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
