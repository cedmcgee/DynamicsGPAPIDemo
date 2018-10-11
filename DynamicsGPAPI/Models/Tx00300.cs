﻿using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Tx00300
    {
        public string TaxReturnId { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public string TaxReturnDescription { get; set; }
        public decimal TotalSalesTax { get; set; }
        public decimal EuPurchasesTax { get; set; }
        public decimal TotalTax { get; set; }
        public decimal TotalPurchasesTax { get; set; }
        public decimal TotalTaxDue { get; set; }
        public decimal TotalSales { get; set; }
        public decimal Totpurch { get; set; }
        public decimal TotalEuSales { get; set; }
        public decimal TotalEuPurchases { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
