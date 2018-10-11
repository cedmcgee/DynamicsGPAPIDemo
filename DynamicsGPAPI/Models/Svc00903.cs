using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00903
    {
        public string Offid { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Strttime { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Endtme { get; set; }
        public byte Contflag { get; set; }
        public byte ServiceFlag { get; set; }
        public string Dscriptn { get; set; }
        public int DexRowId { get; set; }
    }
}
