﻿using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Dta00300
    {
        public int Actindx { get; set; }
        public string Groupid { get; set; }
        public byte DtaQuantities { get; set; }
        public short Acctstat { get; set; }
        public short Decplqty { get; set; }
        public int DexRowId { get; set; }
    }
}
