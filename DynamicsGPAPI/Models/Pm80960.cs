using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pm80960
    {
        public int Ord { get; set; }
        public short Status { get; set; }
        public string Strng132 { get; set; }
        public string Userid { get; set; }
        public short ProcessId { get; set; }
        public int DexRowId { get; set; }
    }
}
