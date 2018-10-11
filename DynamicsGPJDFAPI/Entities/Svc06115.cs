using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc06115
    {
        public byte Mkdtopst { get; set; }
        public short Worectype { get; set; }
        public string Workordnum { get; set; }
        public string Userid { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public string Wotype { get; set; }
        public string Stationid { get; set; }
        public string Offid { get; set; }
        public byte Posted { get; set; }
        public short Ermsgnbr { get; set; }
        public string Ermsgtxt { get; set; }
        public string Ermsgtx2 { get; set; }
        public int DexRowId { get; set; }
    }
}
