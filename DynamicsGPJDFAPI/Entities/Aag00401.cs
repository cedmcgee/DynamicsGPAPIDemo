using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag00401
    {
        public int AaTrxDimId { get; set; }
        public int AaTrxDimCodeId { get; set; }
        public string AaTrxDimCode { get; set; }
        public string AaTrxDimCodeDescr { get; set; }
        public string AaTrxDimCodeDescr2 { get; set; }
        public decimal Noteindx { get; set; }
        public byte Inactive { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
