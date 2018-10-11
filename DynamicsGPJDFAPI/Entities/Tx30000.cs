using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Tx30000
    {
        public string Docnumbr { get; set; }
        public short Doctype { get; set; }
        public short Series { get; set; }
        public decimal Rctrxseq { get; set; }
        public int Seqnumbr { get; set; }
        public string Taxdtlid { get; set; }
        public decimal Txdtlpct { get; set; }
        public decimal Txdtlamt { get; set; }
        public int Actindx { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime TaxDate { get; set; }
        public DateTime Pstgdate { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Ortaxamt { get; set; }
        public decimal TaxableAmount { get; set; }
        public decimal OriginatingTaxableAmt { get; set; }
        public decimal Docamnt { get; set; }
        public decimal Ordocamt { get; set; }
        public byte Ectrx { get; set; }
        public short Voidstts { get; set; }
        public string CustomerVendorId { get; set; }
        public short Currnidx { get; set; }
        public byte IncludedOnReturn { get; set; }
        public string TaxReturnId { get; set; }
        public short Txorgn { get; set; }
        public short Txdtltyp { get; set; }
        public string Trxstats { get; set; }
        public string Retnum { get; set; }
        public short Year1 { get; set; }
        public byte Invatret { get; set; }
        public string Vatcolcd { get; set; }
        public string Vatrptid { get; set; }
        public short RevisionNumber { get; set; }
        public short Periodid { get; set; }
        public byte Isgltrx { get; set; }
        public int DexRowId { get; set; }
    }
}
