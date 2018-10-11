using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class ReportCentersPending
    {
        public int IdentityColumn { get; set; }
        public string BpreportCenter { get; set; }
        public byte Mktoproc { get; set; }
        public short Rptgrind { get; set; }
        public short Prodid { get; set; }
        public string BusinessDeskReportNam { get; set; }
        public string ReportOption { get; set; }
        public string UserIdtime { get; set; }
        public int DexRowId { get; set; }
    }
}
