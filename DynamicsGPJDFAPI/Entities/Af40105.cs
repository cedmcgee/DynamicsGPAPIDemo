﻿using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Af40105
    {
        public short Reportid { get; set; }
        public short Clcolnum { get; set; }
        public short Tknodnum { get; set; }
        public short Tkntype { get; set; }
        public short Tknvalue { get; set; }
        public decimal Tkndlval { get; set; }
        public string Tknunact1 { get; set; }
        public string Tknunact2 { get; set; }
        public string Tknunact3 { get; set; }
        public string Tknunact4 { get; set; }
        public string Tknunact5 { get; set; }
        public int DexRowId { get; set; }
    }
}
