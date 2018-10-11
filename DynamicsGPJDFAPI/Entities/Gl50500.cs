using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Gl50500
    {
        public string Userid { get; set; }
        public int Ord { get; set; }
        public string Sgmntid { get; set; }
        public short LedgerId { get; set; }
        public string Curncyid { get; set; }
        public string TranslationCurrencyId { get; set; }
        public short Currnidx { get; set; }
        public short Decplcur { get; set; }
        public string Ratetpid { get; set; }
        public string Exgtblid { get; set; }
        public decimal Xchgrate { get; set; }
        public short Rtclcmtd { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public short CurrencyTranslationType { get; set; }
        public decimal Rearnamt { get; set; }
        public decimal Origamt { get; set; }
        public decimal TranslationAmount { get; set; }
        public int Rerindx { get; set; }
        public int DexRowId { get; set; }
    }
}
