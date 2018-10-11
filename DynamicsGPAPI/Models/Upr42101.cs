using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Upr42101
    {
        public string PaySchedule { get; set; }
        public short Year1 { get; set; }
        public short Periodid { get; set; }
        public string Pername { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public int DexRowId { get; set; }
    }
}
