using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Gl40200
    {
        public short Sgmtnumb { get; set; }
        public string Sgmntid { get; set; }
        public string Dscriptn { get; set; }
        public int Segcount { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
