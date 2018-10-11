using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Asiloc90
    {
        public short Setupkey { get; set; }
        public byte AsiShowInactive { get; set; }
        public string AsiQlKeyLabel1 { get; set; }
        public string AsiQlKeyLabel2 { get; set; }
        public string AsiQlKeyLabel3 { get; set; }
        public string AsiQlKeyLabel4 { get; set; }
        public short AsiQlKeyFieldId1 { get; set; }
        public short AsiQlKeyFieldId2 { get; set; }
        public short AsiQlKeyFieldId3 { get; set; }
        public short AsiQlKeyFieldId4 { get; set; }
        public int DexRowId { get; set; }
    }
}
