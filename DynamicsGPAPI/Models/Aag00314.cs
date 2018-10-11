﻿using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag00314
    {
        public int AaMlqueryId { get; set; }
        public short AaColumn { get; set; }
        public byte AaUseTree { get; set; }
        public byte AaUseCodes { get; set; }
        public int AaTreeId { get; set; }
        public int AaTreeLevel { get; set; }
        public byte AaInclEmptyCodes { get; set; }
        public short AaSelectOption { get; set; }
        public string AaFromStr { get; set; }
        public string AaToStr { get; set; }
        public decimal AaFromNum { get; set; }
        public decimal AaToNum { get; set; }
        public byte AaFromBool { get; set; }
        public byte AaToBool { get; set; }
        public DateTime AaFromDate { get; set; }
        public DateTime AaToDate { get; set; }
        public string FromAccountNumber1 { get; set; }
        public string FromAccountNumber2 { get; set; }
        public string FromAccountNumber3 { get; set; }
        public string FromAccountNumber4 { get; set; }
        public string FromAccountNumber5 { get; set; }
        public string ToAccountNumber1 { get; set; }
        public string ToAccountNumber2 { get; set; }
        public string ToAccountNumber3 { get; set; }
        public string ToAccountNumber4 { get; set; }
        public string ToAccountNumber5 { get; set; }
        public int DexRowId { get; set; }
    }
}
