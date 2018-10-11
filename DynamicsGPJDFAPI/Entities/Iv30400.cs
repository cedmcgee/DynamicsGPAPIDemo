using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Iv30400
    {
        public string Trxsorce { get; set; }
        public short Ivdoctyp { get; set; }
        public string Docnumbr { get; set; }
        public decimal Lnseqnbr { get; set; }
        public int Sltsqnum { get; set; }
        public string Serltnum { get; set; }
        public decimal Serltqty { get; set; }
        public string Frombin { get; set; }
        public string Tobin { get; set; }
        public string Itemnmbr { get; set; }
        public DateTime Mfgdate { get; set; }
        public DateTime Expndate { get; set; }
        public int DexRowId { get; set; }
    }
}
