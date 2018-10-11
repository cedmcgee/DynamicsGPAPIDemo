using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Iv30100
    {
        public string Trxsorce { get; set; }
        public string Bchsourc { get; set; }
        public string Bachnumb { get; set; }
        public string Bchcomnt { get; set; }
        public short Bachfreq { get; set; }
        public DateTime Posteddt { get; set; }
        public byte Histrmvd { get; set; }
        public decimal Bchtotal { get; set; }
        public decimal Cntrltot { get; set; }
        public int Numoftrx { get; set; }
        public int Cntrltrx { get; set; }
        public int DexRowId { get; set; }
    }
}
