using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sy04901
    {
        public string EmailMessageId { get; set; }
        public short EmailDictionaryId { get; set; }
        public short EmailSeriesId { get; set; }
        public short EmailDocumentId { get; set; }
        public string WorkflowTypeName { get; set; }
        public string EmailMessageDesc { get; set; }
        public string EmailMessageSubject { get; set; }
        public string EmailMessageFrom { get; set; }
        public short EmailMessageType { get; set; }
        public int DexRowId { get; set; }
        public string EmailReplyToAddress { get; set; }
        public string EmailMessageBody { get; set; }
    }
}
