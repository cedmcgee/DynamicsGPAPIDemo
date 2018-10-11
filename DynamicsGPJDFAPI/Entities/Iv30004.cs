using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Iv30004
    {
        public short Doctype { get; set; }
        public string BinXferDocNumber { get; set; }
        public DateTime BinXferDate { get; set; }
        public int Seqnumbr { get; set; }
        public string Itemnmbr { get; set; }
        public string Locncode { get; set; }
        public short Qtytype { get; set; }
        public string Frombin { get; set; }
        public string Tobin { get; set; }
        public string Serltnum { get; set; }
        public decimal Serltqty { get; set; }
        public DateTime Daterecd { get; set; }
        public decimal Dtseqnum { get; set; }
        public short Ovrserlt { get; set; }
        public string ReasonCode { get; set; }
        public string Userid { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
