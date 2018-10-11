using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Wf30100
    {
        public string WorkflowInstanceId { get; set; }
        public string WorkflowStepInstanceId { get; set; }
        public string WorkflowHistoryUser { get; set; }
        public string WorkflowName { get; set; }
        public string WorkflowStepName { get; set; }
        public string WorkflowStepAssignTo { get; set; }
        public short WorkflowAction { get; set; }
        public DateTime WorkflowDueDate { get; set; }
        public DateTime WorkflowDueTime { get; set; }
        public DateTime WorkflowCompletionDate { get; set; }
        public DateTime WorkflowCompletionTime { get; set; }
        public short Milliseconds { get; set; }
        public int DexRowId { get; set; }
        public string WorkflowComments { get; set; }
    }
}
