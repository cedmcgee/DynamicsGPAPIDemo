using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Iv30700
    {
        public string Stckcntid { get; set; }
        public int Seqnumbr { get; set; }
        public string Stckcntdscrptn { get; set; }
        public DateTime Cntstrtdt { get; set; }
        public DateTime Cntstrttm { get; set; }
        public string Ivdocnbr { get; set; }
        public short Ivdoctyp { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Docdate { get; set; }
        public int DexRowId { get; set; }
    }
}
