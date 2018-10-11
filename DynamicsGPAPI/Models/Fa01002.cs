using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Fa01002
    {
        public DateTime Purgedate { get; set; }
        public DateTime Purgetime { get; set; }
        public string Userid { get; set; }
        public int Assetindex { get; set; }
        public string Assetid { get; set; }
        public short Assetidsuf { get; set; }
        public string Assetdesc { get; set; }
        public short Assetstatus { get; set; }
        public DateTime Assetstatdt { get; set; }
        public int DexRowId { get; set; }
    }
}
