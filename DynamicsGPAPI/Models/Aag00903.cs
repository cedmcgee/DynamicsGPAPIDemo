using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag00903
    {
        public int AaBudgetId { get; set; }
        public string AaBudget { get; set; }
        public string AaBudgetDescr { get; set; }
        public int AaBudgetTreeId { get; set; }
        public short BasedOn { get; set; }
        public short Year1 { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime Todate { get; set; }
        public string Budpwrd { get; set; }
        public byte AaBudgetRollUp { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
