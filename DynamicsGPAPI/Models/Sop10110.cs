using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sop10110
    {
        public string Prcshid { get; set; }
        public string Descexpr { get; set; }
        public byte Ntpronly { get; set; }
        public byte Active { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public decimal Noteindx { get; set; }
        public byte Promo { get; set; }
        public string Curncyid { get; set; }
        public int DexRowId { get; set; }
    }
}
