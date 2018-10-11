using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sy04900
    {
        public short Setupkey { get; set; }
        public byte EmailAllowEmbedding { get; set; }
        public byte EmailAllowAttachments { get; set; }
        public byte EmailAllowDocXattach { get; set; }
        public byte EmailAllowHtmlattach { get; set; }
        public byte EmailAllowPdfattach { get; set; }
        public byte EmailAllowXpsattach { get; set; }
        public int DexRowId { get; set; }
    }
}
