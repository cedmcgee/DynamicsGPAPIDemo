using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Faupdate
    {
        public short Index1 { get; set; }
        public short MajorVersion { get; set; }
        public short MinorVersion { get; set; }
        public short BuildNumber { get; set; }
        public int DexRowId { get; set; }
    }
}
