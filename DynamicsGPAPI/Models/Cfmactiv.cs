using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Cfmactiv
    {
        public string Userid { get; set; }
        public string EbsForecastId { get; set; }
        public DateTime Logindat { get; set; }
        public DateTime Logintim { get; set; }
        public int DexRowId { get; set; }
    }
}
