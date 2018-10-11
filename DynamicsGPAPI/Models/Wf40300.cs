using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Wf40300
    {
        public short DayOfWeek { get; set; }
        public byte IsWorkDay { get; set; }
        public DateTime Strttime { get; set; }
        public DateTime Endtime { get; set; }
        public int DexRowId { get; set; }
    }
}
