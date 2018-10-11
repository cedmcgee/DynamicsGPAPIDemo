using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sop00100
    {
        public string Prchldid { get; set; }
        public string Dscriptn { get; set; }
        public string Password { get; set; }
        public byte Xferphol { get; set; }
        public byte Postphol { get; set; }
        public byte Fufiphol { get; set; }
        public byte Prinphol { get; set; }
        public byte Workflowhold { get; set; }
        public decimal Noteindx { get; set; }
        public string User2ent { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public int DexRowId { get; set; }
    }
}
