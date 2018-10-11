using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Fa41200
    {
        public int Insclassindx { get; set; }
        public string Insclassid { get; set; }
        public string Insclassdesc { get; set; }
        public short Inflationratepct { get; set; }
        public short Deprratepct { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; }
        public int DexRowId { get; set; }
    }
}
