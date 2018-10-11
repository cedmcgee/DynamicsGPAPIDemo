using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Upr10110
    {
        public short Year1 { get; set; }
        public string Employid { get; set; }
        public string Benefit { get; set; }
        public DateTime EffectiveDate { get; set; }
        public short OfferOfCoverageCode { get; set; }
        public short SafeHarborCode { get; set; }
        public string ChangebyI { get; set; }
        public DateTime ChangedateI { get; set; }
        public int DexRowId { get; set; }
    }
}
