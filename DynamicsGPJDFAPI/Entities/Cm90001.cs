using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Cm90001
    {
        public string Chekbkid { get; set; }
        public string EftgenerationTimestamp { get; set; }
        public string Userid { get; set; }
        public decimal TotalDebitAmount { get; set; }
        public decimal TotCrdAmt { get; set; }
        public int TotalNumberofDebits { get; set; }
        public int TotalNumberofCredits { get; set; }
        public string Filename { get; set; }
        public int DexRowId { get; set; }
    }
}
