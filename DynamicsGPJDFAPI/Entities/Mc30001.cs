﻿using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Mc30001
    {
        public string Curncyid { get; set; }
        public short Currnidx { get; set; }
        public int Actindx { get; set; }
        public short Hstyear { get; set; }
        public short Periodid { get; set; }
        public short LedgerId { get; set; }
        public decimal Functamt { get; set; }
        public decimal Origamt { get; set; }
        public int DexRowId { get; set; }
    }
}
