using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Iv00400
    {
        public string Itemnmbr { get; set; }
        public byte Quote { get; set; }
        public byte Prder { get; set; }
        public byte Fulfill { get; set; }
        public byte Invoicecb { get; set; }
        public int DexRowId { get; set; }
    }
}
