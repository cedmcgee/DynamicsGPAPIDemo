using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00211
    {
        public short Srvrectype { get; set; }
        public string Callnbr { get; set; }
        public string SvcTaskId { get; set; }
        public string SvcTaskName { get; set; }
        public string Userid { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public short SvcEscalationStatus { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Endtime { get; set; }
        public int SvcTaskStartDate { get; set; }
        public int SvcTaskStartTime { get; set; }
        public int SvcTaskEndDate { get; set; }
        public int SvcTaskEndTime { get; set; }
        public string SvcCommandText { get; set; }
        public string SvcTaskComment { get; set; }
        public int DexRowId { get; set; }
    }
}
