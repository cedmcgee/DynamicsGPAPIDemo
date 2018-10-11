using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc06110
    {
        public short Worectype { get; set; }
        public string Workordnum { get; set; }
        public int Lnitmseq { get; set; }
        public string Frmwostat { get; set; }
        public string Towostat { get; set; }
        public string Stationid { get; set; }
        public string Techid { get; set; }
        public string SvcAuditDescription { get; set; }
        public string Userid { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Createtime { get; set; }
        public int DexRowId { get; set; }
    }
}
