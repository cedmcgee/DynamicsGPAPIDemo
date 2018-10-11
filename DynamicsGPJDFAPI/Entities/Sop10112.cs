using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sop10112
    {
        public string Sopnumbe { get; set; }
        public short Soptype { get; set; }
        public int Ord { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime Time1 { get; set; }
        public short Sopstatus { get; set; }
        public string Userid { get; set; }
        public int DexRowId { get; set; }
    }
}
