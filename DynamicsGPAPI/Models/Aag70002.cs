﻿using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag70002
    {
        public string Userid { get; set; }
        public string Trxbtchsrc { get; set; }
        public int AaGlhdrId { get; set; }
        public int AaGldistId { get; set; }
        public int AaGlassignId { get; set; }
        public decimal Debitamt { get; set; }
        public short Series { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Ordbtamt { get; set; }
        public decimal Orcrdamt { get; set; }
        public string DistRef { get; set; }
        public int DexRowId { get; set; }
    }
}
