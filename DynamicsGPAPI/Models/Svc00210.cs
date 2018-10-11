using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00210
    {
        public string Callnbr { get; set; }
        public short Srvrectype { get; set; }
        public int Lnitmseq { get; set; }
        public string Frmstat { get; set; }
        public string Tostat { get; set; }
        public string Techid { get; set; }
        public string Dscriptn { get; set; }
        public string Userid { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Createtime { get; set; }
        public int DexRowId { get; set; }
    }
}
