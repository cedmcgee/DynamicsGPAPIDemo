using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag00800
    {
        public int AaAliasId { get; set; }
        public string AaAlias { get; set; }
        public string AaDescription { get; set; }
        public string AaShortDescription { get; set; }
        public byte AaInactive { get; set; }
        public DateTime Modifdt { get; set; }
        public string Mdfusrid { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
