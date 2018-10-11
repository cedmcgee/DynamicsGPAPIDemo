using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Af50001
    {
        public string Userid { get; set; }
        public short Reportid { get; set; }
        public short Amntfrom { get; set; }
        public string Budgetid { get; set; }
        public short Hstyear { get; set; }
        public int Staccndx { get; set; }
        public int Edaccndx { get; set; }
        public byte Alrdycal { get; set; }
        public byte Cnsoldtd { get; set; }
        public string Mulcmpid { get; set; }
        public short Prcssqnc { get; set; }
        public int DexRowId { get; set; }
    }
}
