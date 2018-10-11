using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Wf100003
    {
        public string WorkflowStepName { get; set; }
        public string WorkflowName { get; set; }
        public int WorkflowVersion { get; set; }
        public string WfStepDescription { get; set; }
        public int WorkflowStepSequence { get; set; }
        public short WorkflowStepType { get; set; }
        public short WorkflowStepOrder { get; set; }
        public short WorkflowStepCondition { get; set; }
        public string WorkflowStepConditions { get; set; }
        public string WfStepPredecessor { get; set; }
        public string WorkflowStepAssignTo { get; set; }
        public string EmailMessageId { get; set; }
        public byte WorkflowStepSendEmail { get; set; }
        public short WorkflowStepTimeLimit { get; set; }
        public short WfStepTimeLimitUofM { get; set; }
        public short WfStepCompletionPolic { get; set; }
        public byte WfApplyWfCalendar { get; set; }
        public decimal Noteindx { get; set; }
        public byte WfincludeDocumentAttach { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
