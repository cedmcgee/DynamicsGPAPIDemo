using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Me142815
    {
        public string Meardlid { get; set; }
        public string Arnum { get; set; }
        public string Bnkactnm { get; set; }
        public string Mebankid { get; set; }
        public DateTime MeCuttoffDate { get; set; }
        public DateTime MeBeginDate { get; set; }
        public DateTime MeEndDate { get; set; }
        public short MeNumberOfChecks { get; set; }
        public decimal MeChecksAmount { get; set; }
        public short MeNumberOfCredits { get; set; }
        public decimal MeCreditsTotal { get; set; }
        public short MeNumberOfDebits { get; set; }
        public decimal MeDebitsTotal { get; set; }
        public short MeNumberOfDeps { get; set; }
        public decimal MeDepsAmount { get; set; }
        public short MeNumberOfOther { get; set; }
        public decimal MeOthersAmount { get; set; }
        public int DexRowId { get; set; }
    }
}
