using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Tx00301
    {
        public string TaxReturnId { get; set; }
        public short Exception { get; set; }
        public short Series { get; set; }
        public short Doctype { get; set; }
        public string Docdescr { get; set; }
        public string Docnumbr { get; set; }
        public string Custnmbr { get; set; }
        public string Custname { get; set; }
        public string Taxdtlid { get; set; }
        public DateTime TaxDate { get; set; }
        public DateTime Pstgdate { get; set; }
        public decimal Slsamnt { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal EuPurchasesTax { get; set; }
        public byte Ectrx { get; set; }
        public short Voidstts { get; set; }
        public int DexRowId { get; set; }
    }
}
