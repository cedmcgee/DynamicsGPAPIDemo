using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Iv30702
    {
        public string Stckcntid { get; set; }
        public int Seqnumbr { get; set; }
        public string Itemnmbr { get; set; }
        public string Locncode { get; set; }
        public string Binnmbr { get; set; }
        public int Sltsqnum { get; set; }
        public decimal Countedqty { get; set; }
        public decimal Capturedqty { get; set; }
        public short Itmtrkop { get; set; }
        public string Ivdocnbr { get; set; }
        public short Ivdoctyp { get; set; }
        public string Serltnum { get; set; }
        public decimal Varianceqty { get; set; }
        public DateTime Mfgdate { get; set; }
        public DateTime Expndate { get; set; }
        public int DexRowId { get; set; }
    }
}
