using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag05001
    {
        public string Userid { get; set; }
        public int Jrnentry { get; set; }
        public short Dcstatus { get; set; }
        public decimal Rctrxseq { get; set; }
        public short Year1 { get; set; }
        public string Trxsorce { get; set; }
        public DateTime Trxdate { get; set; }
        public int DexRowId { get; set; }
    }
}
