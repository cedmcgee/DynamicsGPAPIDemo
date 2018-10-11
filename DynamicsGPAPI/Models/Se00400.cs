using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Se00400
    {
        public string Userid { get; set; }
        public string Actnumbr1 { get; set; }
        public string Actnumbr2 { get; set; }
        public string Actnumbr3 { get; set; }
        public string Actnumbr4 { get; set; }
        public string Actnumbr5 { get; set; }
        public short SeZeroNm { get; set; }
        public short SeZeroPb { get; set; }
        public decimal Netamnt { get; set; }
        public decimal Perdblnc { get; set; }
        public short Sesorno1 { get; set; }
        public string Sesort1 { get; set; }
        public short Openyear { get; set; }
        public int Actindx { get; set; }
        public int DexRowId { get; set; }
    }
}
