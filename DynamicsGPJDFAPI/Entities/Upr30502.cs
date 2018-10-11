using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Upr30502
    {
        public string Employid { get; set; }
        public string PaySchedule { get; set; }
        public short Year1 { get; set; }
        public short Periodid { get; set; }
        public int Trxnumber { get; set; }
        public decimal Lnseqnbr { get; set; }
        public DateTime Strttime { get; set; }
        public DateTime Endtime { get; set; }
        public decimal Untstopy { get; set; }
        public int DexRowId { get; set; }
    }
}
