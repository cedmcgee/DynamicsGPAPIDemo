using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class MinPonum
    {
        public string Ponumber { get; set; }
        public string Rcptnmbr { get; set; }
        public byte NeverDefaultPrevious { get; set; }
        public int DexRowId { get; set; }
    }
}
