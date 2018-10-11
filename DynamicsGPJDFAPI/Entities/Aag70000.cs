using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag70000
    {
        public string Userid { get; set; }
        public string Trxbtchsrc { get; set; }
        public int AaGlhdrId { get; set; }
        public int Jrnentry { get; set; }
        public short Series { get; set; }
        public DateTime Glpostdt { get; set; }
        public string AaGltrxsource { get; set; }
        public string AaTrxsource { get; set; }
        public decimal Rctrxseq { get; set; }
        public short Year1 { get; set; }
        public int DexRowId { get; set; }
    }
}
