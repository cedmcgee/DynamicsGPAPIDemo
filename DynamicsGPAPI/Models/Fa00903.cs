using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Fa00903
    {
        public DateTime Transdatestamp { get; set; }
        public DateTime Transtimestamp { get; set; }
        public string Transuserid { get; set; }
        public short Fmyear { get; set; }
        public short Fmperiod { get; set; }
        public short Toyear { get; set; }
        public short Toperiod { get; set; }
        public int Recread { get; set; }
        public int Recwritten { get; set; }
        public int Recprocessed { get; set; }
        public int DexRowId { get; set; }
    }
}
