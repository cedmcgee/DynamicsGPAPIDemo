﻿using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Cm20400
    {
        public decimal Cmdnumwk { get; set; }
        public byte Voided { get; set; }
        public int Dstsqnum { get; set; }
        public int Actindx { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public string DistRef { get; set; }
        public DateTime Glpostdt { get; set; }
        public decimal Orcrdamt { get; set; }
        public decimal Ordbtamt { get; set; }
        public int DexRowId { get; set; }
    }
}
