using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Fa10100
    {
        public string Userid { get; set; }
        public string Groupname { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public int DexRowId { get; set; }
    }
}
