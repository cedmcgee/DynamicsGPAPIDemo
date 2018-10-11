using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Palbdtl
    {
        public string LockboxId { get; set; }
        public short PaRowType { get; set; }
        public short PaFieldNumber { get; set; }
        public short PaMapsTo { get; set; }
        public short PaStartPosition { get; set; }
        public short EndPosition { get; set; }
        public int DexRowId { get; set; }
    }
}
