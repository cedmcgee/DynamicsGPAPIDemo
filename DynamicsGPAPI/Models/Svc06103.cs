using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc06103
    {
        public short Worectype { get; set; }
        public string Workordnum { get; set; }
        public string Stationid { get; set; }
        public short Status { get; set; }
        public decimal RouteSequence { get; set; }
        public string Techid { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Strttime { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Endtime { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
