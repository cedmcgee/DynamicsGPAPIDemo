using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Cm50507
    {
        public DateTime Posteddt { get; set; }
        public string CmtrxNum { get; set; }
        public string Trxsorce { get; set; }
        public string Docnumbr { get; set; }
        public short Doctype { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal DepAmt { get; set; }
        public string Strval { get; set; }
        public byte Voided { get; set; }
        public int DexRowId { get; set; }
    }
}
