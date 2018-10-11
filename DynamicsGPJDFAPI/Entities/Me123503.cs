using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Me123503
    {
        public string Meupldid { get; set; }
        public DateTime Meupdt { get; set; }
        public DateTime Meuptim { get; set; }
        public DateTime Mklsstdd { get; set; }
        public DateTime Meldtdt { get; set; }
        public short Menumuplds { get; set; }
        public string PpNumber { get; set; }
        public short MeNumberOfChecks { get; set; }
        public short MeNumberOfVoids { get; set; }
        public decimal MeChecksAmount { get; set; }
        public decimal MeVoidsAmount { get; set; }
        public string MeConfirmationNumber { get; set; }
        public int DexRowId { get; set; }
    }
}
