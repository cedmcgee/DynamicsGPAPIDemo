using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Gl30001
    {
        public string TranslationCurrencyId { get; set; }
        public short Hstyear { get; set; }
        public int Jrnentry { get; set; }
        public string Sourcdoc { get; set; }
        public string Refrence { get; set; }
        public DateTime Trxdate { get; set; }
        public string Trxsorce { get; set; }
        public int Actindx { get; set; }
        public int Seqnumbr { get; set; }
        public short Periodid { get; set; }
        public short LedgerId { get; set; }
        public string Curncyid { get; set; }
        public decimal OriginalExchangeRate { get; set; }
        public string Orgntsrc { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Orcrdamt { get; set; }
        public decimal Ordbtamt { get; set; }
        public decimal TranslationCreditAmount { get; set; }
        public decimal TranslationDebitAmount { get; set; }
        public short Currnidx { get; set; }
        public short Decplcur { get; set; }
        public string Ratetpid { get; set; }
        public string Exgtblid { get; set; }
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public short CurrencyTranslationType { get; set; }
        public int IdentityColumn { get; set; }
        public int DexRowId { get; set; }
    }
}
