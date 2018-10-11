using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sy04904
    {
        public short EmailDictionaryId { get; set; }
        public short EmailSeriesId { get; set; }
        public string EmailCardId { get; set; }
        public byte EmailAllowEmbedding { get; set; }
        public byte EmailAllowAttachments { get; set; }
        public byte AllowMultipleAtt { get; set; }
        public byte EmailSetFileSize { get; set; }
        public decimal EmailMaxFileSize { get; set; }
        public short EmailAddressOption { get; set; }
        public int DexRowId { get; set; }
    }
}
