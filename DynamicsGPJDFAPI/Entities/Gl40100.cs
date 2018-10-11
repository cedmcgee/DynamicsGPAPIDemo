using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Gl40100
    {
        public string Bsnsfmid { get; set; }
        public string Bsnsfdsc { get; set; }
        public int Offindx { get; set; }
        public byte Ovoacnum { get; set; }
        public byte[] Bchemsg1 { get; set; }
        public byte[] Bchemsg2 { get; set; }
        public string Sourcdoc { get; set; }
        public string Refrence { get; set; }
        public byte Brkdnall { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
