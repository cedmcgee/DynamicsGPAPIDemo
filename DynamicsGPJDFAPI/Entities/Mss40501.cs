using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Mss40501
    {
        public string Stmntid { get; set; }
        public short MssBranchOption { get; set; }
        public string MssBranchCode { get; set; }
        public byte MssExclUnappliedPymts { get; set; }
        public int DexRowId { get; set; }
    }
}
