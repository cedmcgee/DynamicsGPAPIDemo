using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Upr30100
    {
        public string Auctrlcd { get; set; }
        public string Cheknmbr { get; set; }
        public int Pyadnmbr { get; set; }
        public byte Voided { get; set; }
        public DateTime Chekdate { get; set; }
        public DateTime Posteddt { get; set; }
        public string Employid { get; set; }
        public string Emplname { get; set; }
        public decimal Grwgprn { get; set; }
        public decimal Fdwdgprn { get; set; }
        public decimal Fdtxtips { get; set; }
        public decimal Ficamwpr { get; set; }
        public decimal Ficmtptx { get; set; }
        public decimal UncollectedFicamedTaxP { get; set; }
        public decimal Fcaswpr { get; set; }
        public decimal Ficstptx { get; set; }
        public decimal UncollectedFicassTaxP { get; set; }
        public decimal Adeicpmt { get; set; }
        public decimal ReportedTips { get; set; }
        public decimal ChargedTips { get; set; }
        public decimal Aloctips { get; set; }
        public decimal Ttlddtns { get; set; }
        public decimal Ttlbnfts { get; set; }
        public decimal Ntwpyrn { get; set; }
        public string Chekbkid { get; set; }
        public string Deprtmnt { get; set; }
        public string Socscnum { get; set; }
        public decimal Vactmacc { get; set; }
        public decimal Vactmlbl { get; set; }
        public int Vacavlbl { get; set; }
        public decimal Sktmaccr { get; set; }
        public decimal Sktmlbty { get; set; }
        public int Siktimav { get; set; }
        public decimal Totltaxs { get; set; }
        public byte VoidedByVoidChecks { get; set; }
        public decimal Fdwgpyrn { get; set; }
        public decimal FederalTipsPayRun { get; set; }
        public decimal Ficasswp { get; set; }
        public decimal FicassTipsPayRun { get; set; }
        public decimal Ficamwgp { get; set; }
        public decimal FicamedTipsPayRun { get; set; }
        public decimal ReportedReceipts { get; set; }
        public decimal ChargedReceipts { get; set; }
        public short Year1 { get; set; }
        public byte Ischeck { get; set; }
        public string Rsnchkvd { get; set; }
        public short Comppyrn { get; set; }
        public decimal Eficasswh { get; set; }
        public decimal EficassTaxOnTips { get; set; }
        public decimal Eficamwpr { get; set; }
        public decimal EficamedTaxOnTips { get; set; }
        public DateTime PayPeriodBeginDate { get; set; }
        public DateTime PayPeriodEndDate { get; set; }
        public int DexRowId { get; set; }
    }
}
