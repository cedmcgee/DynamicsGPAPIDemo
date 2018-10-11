using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Fa41500
    {
        public int Structureindx { get; set; }
        public string Structureid { get; set; }
        public string Structdescr { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; }
        public int DexRowId { get; set; }
    }
}
