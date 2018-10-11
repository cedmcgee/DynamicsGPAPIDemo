using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag50000
    {
        public string Userid { get; set; }
        public string Trxbtchsrc { get; set; }
        public int AaSubLedgerHdrId { get; set; }
        public short Series { get; set; }
        public short Doctype { get; set; }
        public string Docnumbr { get; set; }
        public DateTime Pstgdate { get; set; }
        public int AaOrder { get; set; }
        public int DexRowId { get; set; }
    }
}
