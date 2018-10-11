using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Af40100
    {
        public string Rprtname { get; set; }
        public short Reportid { get; set; }
        public short Rprttype { get; set; }
        public short Clcfrprt { get; set; }
        public short Lstmodif { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
