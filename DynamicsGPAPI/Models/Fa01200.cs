using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Fa01200
    {
        public int PhysicalInventoryIndex { get; set; }
        public string PhysicalLocationId { get; set; }
        public string AssetLabel { get; set; }
        public DateTime VerifiedDate { get; set; }
        public string Pin { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; }
        public int DexRowId { get; set; }
    }
}
