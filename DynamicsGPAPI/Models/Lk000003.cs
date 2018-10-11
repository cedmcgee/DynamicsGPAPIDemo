﻿using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Lk000003
    {
        public int LkLinkNo { get; set; }
        public short LineNumber { get; set; }
        public int Jrnentry { get; set; }
        public int Actindx { get; set; }
        public int Seqnumbr { get; set; }
        public decimal Trxamnt { get; set; }
        public decimal Ortrxamt { get; set; }
        public string Actnumbr1 { get; set; }
        public string Actnumbr2 { get; set; }
        public string Actnumbr3 { get; set; }
        public string Actnumbr4 { get; set; }
        public string Actnumbr5 { get; set; }
        public short Openyear { get; set; }
        public short Currnidx { get; set; }
        public decimal Rctrxseq { get; set; }
        public DateTime Trxdate { get; set; }
        public int DexRowId { get; set; }
    }
}
