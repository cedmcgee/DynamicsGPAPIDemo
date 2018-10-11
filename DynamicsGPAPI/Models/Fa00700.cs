using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Fa00700
    {
        public int Retirementindx { get; set; }
        public short Retireseq { get; set; }
        public int Retireevent { get; set; }
        public int Assetindex { get; set; }
        public string Assetid { get; set; }
        public DateTime Retdatestamp { get; set; }
        public DateTime Rettimestamp { get; set; }
        public short Retirementtype { get; set; }
        public DateTime Retirementdate { get; set; }
        public string Retirementcode { get; set; }
        public decimal Cashproceeds { get; set; }
        public decimal OrigCashProceeds { get; set; }
        public decimal Noncashproceeds { get; set; }
        public decimal OrigNonCashProceeds { get; set; }
        public decimal Expofsale { get; set; }
        public decimal OrigExpensesOfSale { get; set; }
        public int Partialqty { get; set; }
        public decimal Partialcost { get; set; }
        public short Partialpct { get; set; }
        public int Assetindxaftret { get; set; }
        public decimal Noteindx { get; set; }
        public string Curncyid { get; set; }
        public short Currnidx { get; set; }
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public string Exgtblid { get; set; }
        public string Ratetpid { get; set; }
        public short Rtclcmtd { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; }
        public int DexRowId { get; set; }
    }
}
