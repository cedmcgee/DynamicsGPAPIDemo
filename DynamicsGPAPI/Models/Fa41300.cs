using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Fa41300
    {
        public int Acctgrpindex { get; set; }
        public string Acctgrpid { get; set; }
        public string Acctgrpdesc { get; set; }
        public int Deprexpacctindx { get; set; }
        public int Deprresvacctindx { get; set; }
        public int Prioryrdepracctindx { get; set; }
        public int Assetcostacctindx { get; set; }
        public int Proceedsacctindx { get; set; }
        public int Recgainlossacctindx { get; set; }
        public int Nonrecgainlossacctindx { get; set; }
        public int Clearingacctindx { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; }
        public int DexRowId { get; set; }
    }
}
