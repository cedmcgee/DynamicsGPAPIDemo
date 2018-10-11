using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sy40100
    {
        public byte Closed { get; set; }
        public short Series { get; set; }
        public string Odesctn { get; set; }
        public byte Forigin { get; set; }
        public short Periodid { get; set; }
        public DateTime Perioddt { get; set; }
        public string Pername { get; set; }
        public byte Pseries1 { get; set; }
        public byte Pseries2 { get; set; }
        public byte Pseries3 { get; set; }
        public byte Pseries4 { get; set; }
        public byte Pseries5 { get; set; }
        public byte Pseries6 { get; set; }
        public short Year1 { get; set; }
        public DateTime Perdendt { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
