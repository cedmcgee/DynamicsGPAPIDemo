using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Co00101
    {
        public string AttachmentId { get; set; }
        public string FileName { get; set; }
        public string AttachmentDescription { get; set; }
        public string Crusrid { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Createtime { get; set; }
        public string Odesctn { get; set; }
        public byte ViewAttachment { get; set; }
        public byte InternalAttachment { get; set; }
        public byte Deletable { get; set; }
        public string ReplacedAttachment { get; set; }
        public byte AttachmentImage { get; set; }
        public byte AttachmentProductDetails { get; set; }
        public int DexRowId { get; set; }
    }
}
