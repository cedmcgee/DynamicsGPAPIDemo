using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sop10104
    {
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; }
        public string Prchldid { get; set; }
        public byte Delete1 { get; set; }
        public string Userid { get; set; }
        public DateTime Holddate { get; set; }
        public DateTime Time1 { get; set; }
        public string Trxsorce { get; set; }
        public int DexRowId { get; set; }
    }
}
