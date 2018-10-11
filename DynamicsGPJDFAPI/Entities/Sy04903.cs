using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sy04903
    {
        public short EmailDictionaryId { get; set; }
        public short EmailSeriesId { get; set; }
        public short Module1 { get; set; }
        public short EmailDocumentId { get; set; }
        public byte EmailDocumentEnabled { get; set; }
        public string EmailMessageId { get; set; }
        public int DexRowId { get; set; }
    }
}
