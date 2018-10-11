using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Gl00200
    {
        public string Budgetid { get; set; }
        public string Budcomnt { get; set; }
        public byte[] Budpwrd { get; set; }
        public short Year1 { get; set; }
        public short BasedOn { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime Todate { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
