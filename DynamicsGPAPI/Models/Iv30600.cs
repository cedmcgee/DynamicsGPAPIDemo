using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Iv30600
    {
        public short Ivdoctyp { get; set; }
        public string Docnumbr { get; set; }
        public decimal Lnseqnbr { get; set; }
        public int Sltsqnum { get; set; }
        public string Lotatrb1 { get; set; }
        public string Lotatrb2 { get; set; }
        public string Lotatrb3 { get; set; }
        public DateTime Lotatrb4 { get; set; }
        public DateTime Lotatrb5 { get; set; }
        public int DexRowId { get; set; }
    }
}
