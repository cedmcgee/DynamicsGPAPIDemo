﻿using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Fa01001
    {
        public DateTime Purgedate { get; set; }
        public DateTime Purgetime { get; set; }
        public string Userid { get; set; }
        public byte Retired { get; set; }
        public int Retiredcnt { get; set; }
        public byte Deleted { get; set; }
        public int Deletedcnt { get; set; }
        public byte Partialopen { get; set; }
        public int Partialcnt { get; set; }
        public DateTime Priortodate { get; set; }
        public int DexRowId { get; set; }
    }
}
