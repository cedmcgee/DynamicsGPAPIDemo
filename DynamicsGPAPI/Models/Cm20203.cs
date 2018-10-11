using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Cm20203
    {
        public string Chekbkid { get; set; }
        public string Bchsourc { get; set; }
        public string Bachnumb { get; set; }
        public DateTime Posteddt { get; set; }
        public int Numoftrx { get; set; }
        public decimal Bchtotal { get; set; }
        public string Userid { get; set; }
        public string EftgenerationTimestamp { get; set; }
        public short EftStatus { get; set; }
        public short Series { get; set; }
        public int DexRowId { get; set; }
    }
}
