﻿using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Gl00201
    {
        public string Budgetid { get; set; }
        public string Actnumbr1 { get; set; }
        public string Actnumbr2 { get; set; }
        public string Actnumbr3 { get; set; }
        public string Actnumbr4 { get; set; }
        public string Actnumbr5 { get; set; }
        public DateTime Perioddt { get; set; }
        public short Periodid { get; set; }
        public decimal Budgetamt { get; set; }
        public short Accatnum { get; set; }
        public int Actindx { get; set; }
        public short Year1 { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
