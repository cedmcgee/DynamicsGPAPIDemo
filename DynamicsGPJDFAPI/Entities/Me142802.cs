using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Me142802
    {
        public string Arnum { get; set; }
        public string Mebankid { get; set; }
        public string OutputFormat { get; set; }
        public string Bankid { get; set; }
        public string Bankname { get; set; }
        public string Bnkbrnch { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public byte Hypelink { get; set; }
        public string Ardlfilapth { get; set; }
        public string MeCommLinkPath { get; set; }
        public string Meardlid { get; set; }
        public DateTime Mklsstdd { get; set; }
        public DateTime Meldtdt { get; set; }
        public DateTime LastReconciledDate { get; set; }
        public decimal LastReconciledBalance { get; set; }
        public short MeNumberOfChecks { get; set; }
        public short MeNumberOfDeps { get; set; }
        public decimal MeDebitsTotal { get; set; }
        public decimal MeCreditsTotal { get; set; }
        public DateTime Userdate { get; set; }
        public string Userid { get; set; }
        public int DexRowId { get; set; }
    }
}
