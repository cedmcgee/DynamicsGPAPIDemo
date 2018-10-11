using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Rm00401
    {
        public string Docnumbr { get; set; }
        public short Rmdtypal { get; set; }
        public short Dcstatus { get; set; }
        public string Bchsourc { get; set; }
        public string Trxsorce { get; set; }
        public string Custnmbr { get; set; }
        public string Cheknmbr { get; set; }
        public DateTime Docdate { get; set; }
        public byte Negqtysopinv { get; set; }
        public int DexRowId { get; set; }
    }
}
