using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00922
    {
        public string Srvtype { get; set; }
        public int Lnitmseq { get; set; }
        public short Esctype { get; set; }
        public string Frmstat { get; set; }
        public string Tostat { get; set; }
        public string Techid { get; set; }
        public short PriorityLevel { get; set; }
        public int Waittme { get; set; }
        public short SvcManagerLevel { get; set; }
        public int DexRowId { get; set; }
    }
}
