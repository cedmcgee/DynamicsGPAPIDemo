using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Co00102
    {
        public string BusObjKey { get; set; }
        public string AttachmentId { get; set; }
        public string Crusrid { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Createtime { get; set; }
        public byte Histrx { get; set; }
        public short AllowAttachmentFlow { get; set; }
        public byte Delete1 { get; set; }
        public short AllowAttachmentEmail { get; set; }
        public short AttachmentOrigin { get; set; }
        public string WorkflowStepInstanceId { get; set; }
        public int DexRowId { get; set; }
    }
}
