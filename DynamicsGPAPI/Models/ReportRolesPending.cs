using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class ReportRolesPending
    {
        public int IdentityColumn { get; set; }
        public string BpGuid { get; set; }
        public string BpRole { get; set; }
        public byte Mktoproc { get; set; }
        public string BusinessDeskReportNam { get; set; }
        public short Prodid { get; set; }
        public string ReportOption { get; set; }
        public short Rptgrind { get; set; }
        public string UserIdtime { get; set; }
        public int DexRowId { get; set; }
    }
}
