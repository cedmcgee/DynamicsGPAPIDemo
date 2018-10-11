using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag60000
    {
        public string Userid { get; set; }
        public string Trxbtchsrc { get; set; }
        public int AaGlworkHdrId { get; set; }
        public int Jrnentry { get; set; }
        public short Series { get; set; }
        public DateTime Glpostdt { get; set; }
        public int DexRowId { get; set; }
    }
}
