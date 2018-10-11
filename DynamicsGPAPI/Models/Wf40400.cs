using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Wf40400
    {
        public string WorkflowTypeName { get; set; }
        public string WorkflowName { get; set; }
        public short WfNotificationAction { get; set; }
        public byte WfNotificationEnabled { get; set; }
        public string EmailMessageId { get; set; }
        public string WorkflowNotificationCc { get; set; }
        public int DexRowId { get; set; }
    }
}
