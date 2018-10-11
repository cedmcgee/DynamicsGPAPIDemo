using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class WkPostingValidationState
    {
        public string Bchsourc { get; set; }
        public string Bachnumb { get; set; }
        public byte[] Glbchval { get; set; }
        public int DexRowId { get; set; }
    }
}
