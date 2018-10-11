using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc30201
    {
        public short Srvrectype { get; set; }
        public string Callnbr { get; set; }
        public int Lnitmseq { get; set; }
        public int Equipid { get; set; }
        public string Itemnmbr { get; set; }
        public string Prdline { get; set; }
        public string Probcde { get; set; }
        public string Causecde { get; set; }
        public string Rprcode { get; set; }
        public decimal NoteIndex1 { get; set; }
        public decimal NoteIndex2 { get; set; }
        public decimal NoteIndex3 { get; set; }
        public int DexRowId { get; set; }
    }
}
