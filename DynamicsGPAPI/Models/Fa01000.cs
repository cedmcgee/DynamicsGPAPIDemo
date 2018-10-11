using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Fa01000
    {
        public byte Reprntnt { get; set; }
        public short Series { get; set; }
        public int Seqnumbr { get; set; }
        public string Trxsourc { get; set; }
        public string Trxsrcpx { get; set; }
        public int Ntrxsnum { get; set; }
        public string Sourcdoc { get; set; }
        public int DexRowId { get; set; }
    }
}
