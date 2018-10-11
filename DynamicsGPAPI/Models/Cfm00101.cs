using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Cfm00101
    {
        public string EbsForecastId { get; set; }
        public string Chekbkid { get; set; }
        public decimal CfmExchangeRate { get; set; }
        public short CfmCalcMethod { get; set; }
        public int DexRowId { get; set; }
    }
}
