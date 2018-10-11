using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pm80800
    {
        public string Trxsorce { get; set; }
        public string Vchrnmbr { get; set; }
        public short Doctype { get; set; }
        public string Campynbr { get; set; }
        public DateTime Chekdate { get; set; }
        public string Cheknmbr { get; set; }
        public string Chamcbid { get; set; }
        public decimal Chekamnt { get; set; }
        public int DexRowId { get; set; }
    }
}
