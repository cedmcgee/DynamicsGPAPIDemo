using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00205
    {
        public short Srvrectype { get; set; }
        public int Lnitmseq { get; set; }
        public string Linitmtyp { get; set; }
        public string Dscriptn { get; set; }
        public string Userid { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Createtime { get; set; }
        public short SvcDocumentType { get; set; }
        public string SvcDocumentNumber { get; set; }
        public int DexRowId { get; set; }
    }
}
