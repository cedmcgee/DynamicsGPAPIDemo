using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Bm40100
    {
        public short Setupkey { get; set; }
        public short DefaultDocumentDate { get; set; }
        public byte Kptrxhst { get; set; }
        public string TrxId { get; set; }
        public byte AllowQtyOverride { get; set; }
        public byte Allowserlotlinking { get; set; }
        public string Usrdfpr1 { get; set; }
        public string Usrdrpr2 { get; set; }
        public string Usrdrpr3 { get; set; }
        public string Usrdrpr4 { get; set; }
        public int DexRowId { get; set; }
    }
}
