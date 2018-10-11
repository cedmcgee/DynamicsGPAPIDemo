using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class ReportSetup
    {
        public short Setupkey { get; set; }
        public string ReportUrl { get; set; }
        public string NextReportFileName { get; set; }
        public short Xprtftyp { get; set; }
        public int DexRowId { get; set; }
    }
}
