using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Mc40301
    {
        public string Curncyid { get; set; }
        public string Ratetpid { get; set; }
        public string Exgtblid { get; set; }
        public byte Dfltrate { get; set; }
        public int Realgain { get; set; }
        public int Realloss { get; set; }
        public int Unrlgain { get; set; }
        public int Unrlloss { get; set; }
        public int Finoffst { get; set; }
        public int Puroffst { get; set; }
        public int Slsoffst { get; set; }
        public int Rndwtoff { get; set; }
        public int Rnddiff { get; set; }
        public short BaseExchangeRateOn { get; set; }
        public int DexRowId { get; set; }
    }
}
