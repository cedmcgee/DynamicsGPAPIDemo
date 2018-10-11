using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Wfi10002
    {
        public string WorkflowInstanceId { get; set; }
        public string WorkflowName { get; set; }
        public string WfBusObjKey { get; set; }
        public int WorkflowVersion { get; set; }
        public string WorkflowDescription { get; set; }
        public string WorkflowTypeName { get; set; }
        public short FormId { get; set; }
        public short Dictid { get; set; }
        public short WorkflowStatus { get; set; }
        public byte WfSendNotificatications { get; set; }
        public byte WorkflowManuallyDelega { get; set; }
        public string WorkflowOriginator { get; set; }
        public byte WfAllowOrigApprover { get; set; }
        public byte WorkflowRequireOneApp { get; set; }
        public byte WfUseAltFinalApprov { get; set; }
        public string WfAltFinalApprover { get; set; }
        public short WfOverdueTaskAction { get; set; }
        public string WorkflowDelegateTo { get; set; }
        public string Tblphysnm { get; set; }
        public string DocumentDrillDown { get; set; }
        public decimal Noteindx { get; set; }
        public string BusObjKey { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
        public string WorkflowWhereClause { get; set; }
    }
}
