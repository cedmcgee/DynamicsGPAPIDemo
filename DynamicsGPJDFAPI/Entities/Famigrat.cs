using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Famigrat
    {
        public short Index1 { get; set; }
        public short MajorVersion { get; set; }
        public short MinorVersion { get; set; }
        public short BuildNumber { get; set; }
        public int DexRowId { get; set; }
    }
}
