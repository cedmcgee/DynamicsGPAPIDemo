using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Iv10000
    {
        public string Bachnumb { get; set; }
        public string Bchsourc { get; set; }
        public string Ivdocnbr { get; set; }
        public string Rcdocnum { get; set; }
        public short Ivdoctyp { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime Modifdt { get; set; }
        public string Mdfusrid { get; set; }
        public DateTime Posteddt { get; set; }
        public string Ptdusrid { get; set; }
        public DateTime Glpostdt { get; set; }
        public short Pstgstus { get; set; }
        public decimal Trxqtytl { get; set; }
        public byte[] Ivwhrmsg { get; set; }
        public decimal Noteindx { get; set; }
        public string Srcrfrncnmbr { get; set; }
        public short Sourceindicator { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
