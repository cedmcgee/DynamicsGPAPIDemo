using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Gl10101
    {
        public string Bsnsfmid { get; set; }
        public int Jrnentry { get; set; }
        public decimal Sqncline { get; set; }
        public int Actindx { get; set; }
        public decimal Trxamnt { get; set; }
        public byte[] Gllinmsg { get; set; }
        public string Dscriptn { get; set; }
        public byte[] Gllinval { get; set; }
        public short Accttype { get; set; }
        public short Fxdorvar { get; set; }
        public short Balfrclc { get; set; }
        public short Pstngtyp { get; set; }
        public short Decplacs { get; set; }
        public int DexRowId { get; set; }
    }
}
