using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Cfmtemp
    {
        public string Chekbkid { get; set; }
        public byte Mktoproc { get; set; }
        public decimal CfmExchangeRate { get; set; }
        public short CfmCalcMethod { get; set; }
        public int DexRowId { get; set; }
    }
}
