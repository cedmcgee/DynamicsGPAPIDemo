using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sy40101
    {
        public short Year1 { get; set; }
        public DateTime Fstfscdy { get; set; }
        public DateTime Lstfscdy { get; set; }
        public short Numofper { get; set; }
        public byte Historyr { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
