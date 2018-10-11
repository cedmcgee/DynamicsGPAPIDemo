using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sy04902
    {
        public short EmailDictionaryId { get; set; }
        public short EmailSeriesId { get; set; }
        public short EmailSeriesGetMsgId { get; set; }
        public string EmailMessageFrom { get; set; }
        public byte EmailAcf { get; set; }
        public byte EmailAllowChangeReplyTo { get; set; }
        public byte EmailAllowUpdateEntry { get; set; }
        public int DexRowId { get; set; }
        public string EmailReplyToAddress { get; set; }
    }
}
