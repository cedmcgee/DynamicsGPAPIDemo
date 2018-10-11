using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class CoAttachmentItems
    {
        public string AttachmentId { get; set; }
        public byte[] BinaryBlob { get; set; }
        public string FileName { get; set; }
    }
}
