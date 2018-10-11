using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class ReportCatalog
    {
        public string Prodname { get; set; }
        public string BusinessDeskReportNam { get; set; }
        public string ReportOption { get; set; }
        public string BusinessDeskReportTyp { get; set; }
        public string ReportUrl { get; set; }
        public DateTime LastDatePublished { get; set; }
        public DateTime LastTimePublished { get; set; }
        public short ReportSeries { get; set; }
        public byte Reviewed { get; set; }
        public int DexRowId { get; set; }
    }
}
