using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag10003
    {
        public int AaGlworkHdrId { get; set; }
        public int AaGlworkDistId { get; set; }
        public int AaGlworkAssignId { get; set; }
        public int AaTrxDimId { get; set; }
        public int AaTrxCodeId { get; set; }
        public byte[] AaCodeErrors { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
