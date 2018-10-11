using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Fa42400
    {
        public int PhysicalLocationIndex { get; set; }
        public string PhysicalLocationId { get; set; }
        public string PhysicalLocationDesc { get; set; }
        public string Locatnid { get; set; }
        public DateTime LastInventoryDate { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; }
        public int DexRowId { get; set; }
    }
}
