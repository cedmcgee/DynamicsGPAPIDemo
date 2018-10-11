using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Fa42000
    {
        public int Transferevent { get; set; }
        public string Xfereventdesc { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; }
        public int DexRowId { get; set; }
    }
}
