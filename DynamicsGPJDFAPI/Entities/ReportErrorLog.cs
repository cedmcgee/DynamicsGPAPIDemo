using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class ReportErrorLog
    {
        public string Userid { get; set; }
        public short Prodid { get; set; }
        public short Rptgrind { get; set; }
        public string BusinessDeskReportNam { get; set; }
        public string ReportOption { get; set; }
        public string Ermsgtxt { get; set; }
        public int DexRowId { get; set; }
    }
}
