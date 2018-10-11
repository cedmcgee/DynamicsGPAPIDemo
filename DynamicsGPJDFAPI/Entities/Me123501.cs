using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Me123501
    {
        public string PpNumber { get; set; }
        public string Mebankid { get; set; }
        public string OutputFormat { get; set; }
        public string Bankid { get; set; }
        public string Bankname { get; set; }
        public string Bnkbrnch { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public byte Hypelink { get; set; }
        public string Dlfilapth { get; set; }
        public string Hypepath { get; set; }
        public byte Meincwft { get; set; }
        public string Meupldid { get; set; }
        public DateTime Mklsstdd { get; set; }
        public DateTime Meuptim { get; set; }
        public short MeNumberOfChecks { get; set; }
        public decimal MeChecksAmount { get; set; }
        public short MeNumberOfVoids { get; set; }
        public decimal MeVoidsAmount { get; set; }
        public string MeConfirmationNumber { get; set; }
        public DateTime LastReconciledDate { get; set; }
        public decimal LastReconciledBalance { get; set; }
        public int DexRowId { get; set; }
    }
}
