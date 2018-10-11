using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sy04911
    {
        public int IdentityColumn { get; set; }
        public string Userid { get; set; }
        public short Module1 { get; set; }
        public short Doctype { get; set; }
        public string EmailMessageFrom { get; set; }
        public string EmailSubject { get; set; }
        public byte AllowMultipleAtt { get; set; }
        public short Dictryid { get; set; }
        public string EmailMessageId { get; set; }
        public string MasterId { get; set; }
        public int DexRowId { get; set; }
        public string EmailToAddress { get; set; }
        public string EmailCcAddress { get; set; }
        public string EmailBccAddress { get; set; }
        public string EmailReplyToAddress { get; set; }
        public string EmailBody { get; set; }
    }
}
