using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Co40100
    {
        public short Setupkey { get; set; }
        public byte EnableFeature { get; set; }
        public byte ViewAttachment { get; set; }
        public byte InternalAttachment { get; set; }
        public byte AllowRemoval { get; set; }
        public byte FlowFromItem { get; set; }
        public byte FlowFromVendor { get; set; }
        public byte FlowFromCustomer { get; set; }
        public string ScanLocation { get; set; }
        public byte DeleteAfterAttach { get; set; }
        public byte EmailSetFileSize { get; set; }
        public decimal EmailMaxFileSize { get; set; }
        public byte AllowToDelete { get; set; }
        public string DeletePassword { get; set; }
        public string Attribute1 { get; set; }
        public string Attribute2 { get; set; }
        public string Attribute3 { get; set; }
        public string Attribute4 { get; set; }
        public string Attribute5 { get; set; }
        public short AttachAttributeDefault { get; set; }
        public short CustomerAttachmentType { get; set; }
        public short ItemAttachmentType { get; set; }
        public short VendorAttachmentType { get; set; }
        public byte AllowAttachmentsEmail { get; set; }
        public int DexRowId { get; set; }
    }
}
