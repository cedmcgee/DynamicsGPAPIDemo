﻿using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Iv30102
    {
        public string Itemnmbr { get; set; }
        public string Locncode { get; set; }
        public short Smrytype { get; set; }
        public short Smrypmth { get; set; }
        public short Year1 { get; set; }
        public decimal Smryqtys { get; set; }
        public decimal Smrycost { get; set; }
        public decimal Smrysals { get; set; }
        public decimal Smmrydpndntusgqty { get; set; }
        public decimal Smmrydpndntusgcst { get; set; }
        public decimal Smmryprjctdusgqty { get; set; }
        public int DexRowId { get; set; }
    }
}
