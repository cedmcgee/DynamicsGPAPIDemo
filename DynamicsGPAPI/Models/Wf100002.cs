using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Wf100002
    {
        public string WorkflowName { get; set; }
        public int WorkflowVersion { get; set; }
        public string WorkflowDescription { get; set; }
        public string WorkflowTypeName { get; set; }
        public byte Active { get; set; }
        public byte WfSendNotificatications { get; set; }
        public byte WorkflowManuallyDelega { get; set; }
        public byte WfAllowOrigApprover { get; set; }
        public byte WorkflowRequireOneApp { get; set; }
        public byte WfUseAltFinalApprov { get; set; }
        public string WfAltFinalApprover { get; set; }
        public short WfOverdueTaskAction { get; set; }
        public string WorkflowDelegateTo { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
