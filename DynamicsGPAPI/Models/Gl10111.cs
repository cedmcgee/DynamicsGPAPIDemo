using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Gl10111
    {
        public int Actindx { get; set; }
        public short Year1 { get; set; }
        public short Periodid { get; set; }
        public short LedgerId { get; set; }
        public string Actnumbr1 { get; set; }
        public string Actnumbr2 { get; set; }
        public string Actnumbr3 { get; set; }
        public string Actnumbr4 { get; set; }
        public string Actnumbr5 { get; set; }
        public short Accatnum { get; set; }
        public decimal Perdblnc { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public int DexRowId { get; set; }
    }
}
