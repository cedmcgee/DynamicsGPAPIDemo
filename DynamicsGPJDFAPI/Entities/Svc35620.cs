using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc35620
    {
        public string RtvNumber { get; set; }
        public decimal RtvLine { get; set; }
        public decimal Lnseqnbr { get; set; }
        public string Svcfrmstat { get; set; }
        public string Svctostat { get; set; }
        public string Dscrption { get; set; }
        public string Userid { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Createtime { get; set; }
        public int DexRowId { get; set; }
    }
}
