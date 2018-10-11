using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Upr00903
    {
        public string Employid { get; set; }
        public short Periodid { get; set; }
        public short Year1 { get; set; }
        public decimal ReportedTips { get; set; }
        public decimal ChargedTips { get; set; }
        public decimal Fdtxtips { get; set; }
        public decimal FicassTipsFiscal { get; set; }
        public decimal Ficstptx { get; set; }
        public decimal UncollectedFicassTaxF { get; set; }
        public decimal FicamedTipsFiscal { get; set; }
        public decimal Ficmtptx { get; set; }
        public decimal UncollectFicamedTxFis { get; set; }
        public decimal ReportedReceipts { get; set; }
        public decimal ChargedReceipts { get; set; }
        public decimal AllocatedTipsFiscal { get; set; }
        public decimal FederalTipsFiscal { get; set; }
        public int DexRowId { get; set; }
    }
}
