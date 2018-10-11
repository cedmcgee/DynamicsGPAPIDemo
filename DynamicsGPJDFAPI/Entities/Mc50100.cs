using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Mc50100
    {
        public short Amntfrom { get; set; }
        public string Yearid { get; set; }
        public short Periodid { get; set; }
        public string Curncyid { get; set; }
        public short Currnidx { get; set; }
        public int Actindx { get; set; }
        public decimal Functamt { get; set; }
        public decimal Origamt { get; set; }
        public int DexRowId { get; set; }
    }
}
