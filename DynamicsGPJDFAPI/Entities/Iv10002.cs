using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Iv10002
    {
        public string Ivdocnbr { get; set; }
        public short Ivdoctyp { get; set; }
        public string Itemnmbr { get; set; }
        public string Serltnum { get; set; }
        public decimal Serltqty { get; set; }
        public decimal Lnseqnbr { get; set; }
        public int Sltsqnum { get; set; }
        public DateTime Daterecd { get; set; }
        public decimal Dtseqnum { get; set; }
        public short Ovrserlt { get; set; }
        public decimal Qtyscrapped { get; set; }
        public string Frombin { get; set; }
        public string Tobin { get; set; }
        public DateTime Mfgdate { get; set; }
        public DateTime Expndate { get; set; }
        public int DexRowId { get; set; }
    }
}
