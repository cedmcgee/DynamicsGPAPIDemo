using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class ReportCatalogPending
    {
        public string BusinessDeskReportNam { get; set; }
        public string ReportOption { get; set; }
        public DateTime LastDatePublished { get; set; }
        public string Dscriptn { get; set; }
        public byte Mkdtopst { get; set; }
        public int IdentityColumn { get; set; }
        public string Prodname { get; set; }
        public int ListviewIndex { get; set; }
        public short Rptgrind { get; set; }
        public short Prodid { get; set; }
        public string UserIdtime { get; set; }
        public int DexRowId { get; set; }
    }
}
