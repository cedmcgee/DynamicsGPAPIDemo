using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Wfi10004
    {
        public string WorkflowInstanceId { get; set; }
        public string WorkflowStepInstanceId { get; set; }
        public string WorkflowTaskAssignedTo { get; set; }
        public string WorkflowStepName { get; set; }
        public string WorkflowName { get; set; }
        public int WorkflowVersion { get; set; }
        public string WfStepDescription { get; set; }
        public DateTime WorkflowActionDate { get; set; }
        public DateTime WorkflowActionTime { get; set; }
        public DateTime WorkflowDueDate { get; set; }
        public DateTime WorkflowDueTime { get; set; }
        public int WorkflowStepSequence { get; set; }
        public short WorkflowStepType { get; set; }
        public short WorkflowStepOrder { get; set; }
        public string WfStepPredecessor { get; set; }
        public short WfStepCompletionPolic { get; set; }
        public byte WorkflowTaskEscalated { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
