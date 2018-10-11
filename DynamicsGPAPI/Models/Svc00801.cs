using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00801
    {
        public short Srvrectype { get; set; }
        public string Callnbr { get; set; }
        public int Lnitmseq { get; set; }
        public string Keyword { get; set; }
        public DateTime Entdte { get; set; }
        public string Userid { get; set; }
        public int DexRowId { get; set; }
    }
}
