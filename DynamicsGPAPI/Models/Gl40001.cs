using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Gl40001
    {
        public short LedgerId { get; set; }
        public string LedgerName { get; set; }
        public string LedgerDescription { get; set; }
        public string Uniqkey { get; set; }
        public int DexRowId { get; set; }
    }
}
