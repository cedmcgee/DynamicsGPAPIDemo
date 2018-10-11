﻿using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pop30160
    {
        public string Ponumber { get; set; }
        public int Ord { get; set; }
        public string Taxdtlid { get; set; }
        public byte Bkouttax { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Ortaxamt { get; set; }
        public decimal Frttxamt { get; set; }
        public decimal Orfrttax { get; set; }
        public decimal Msctxamt { get; set; }
        public decimal Ormsctax { get; set; }
        public decimal Taxpurch { get; set; }
        public decimal Orgtxpch { get; set; }
        public decimal Totpurch { get; set; }
        public decimal Ortotpur { get; set; }
        public decimal Txdtottx { get; set; }
        public decimal Ottaxpon { get; set; }
        public string Trxsorce { get; set; }
        public decimal PopTaxNoteIdArray1 { get; set; }
        public decimal PopTaxNoteIdArray2 { get; set; }
        public short Currnidx { get; set; }
        public int DexRowId { get; set; }
    }
}
