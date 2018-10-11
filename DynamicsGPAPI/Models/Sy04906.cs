using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sy04906
    {
        public short EmailDictionaryId { get; set; }
        public short EmailSeriesId { get; set; }
        public short Module1 { get; set; }
        public string EmailCardId { get; set; }
        public short EmailDocumentId { get; set; }
        public string Adrscode { get; set; }
        public string EmailCardAddress { get; set; }
        public byte EmailRecipientTypeTo { get; set; }
        public byte EmailRecipientTypeCc { get; set; }
        public byte EmailRecipientTypeBcc { get; set; }
        public int DexRowId { get; set; }
    }
}
