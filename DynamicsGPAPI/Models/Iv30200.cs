using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Iv30200
    {
        public string Trxsorce { get; set; }
        public short Ivdoctyp { get; set; }
        public string Docnumbr { get; set; }
        public DateTime Docdate { get; set; }
        public string Bchsourc { get; set; }
        public string Bachnumb { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Glpostdt { get; set; }
        public string Srcrfrncnmbr { get; set; }
        public short Sourceindicator { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
