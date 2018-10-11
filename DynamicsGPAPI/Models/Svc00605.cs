using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00605
    {
        public short Consts { get; set; }
        public string Contnbr { get; set; }
        public string Sopnumbe { get; set; }
        public short Soptype { get; set; }
        public DateTime Invodate { get; set; }
        public decimal InvoicedAmount { get; set; }
        public decimal AmountToInvoice { get; set; }
        public decimal OrigInvoicedAmount { get; set; }
        public decimal OrigAmountToInvoice { get; set; }
        public byte SvcReverseFlag { get; set; }
        public int DexRowId { get; set; }
    }
}
