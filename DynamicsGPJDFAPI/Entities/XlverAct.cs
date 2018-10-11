using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class XlverAct
    {
        public string Userid { get; set; }
        public string Actnumbr1 { get; set; }
        public string Actnumbr2 { get; set; }
        public string Actnumbr3 { get; set; }
        public string Actnumbr4 { get; set; }
        public string Actnumbr5 { get; set; }
        public string Actdescr { get; set; }
        public byte Included { get; set; }
        public int DexRowId { get; set; }
    }
}
