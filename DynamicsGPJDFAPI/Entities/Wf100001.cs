using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Wf100001
    {
        public string WorkflowTypeName { get; set; }
        public string WfTypeDescription { get; set; }
        public short FormId { get; set; }
        public short Dictid { get; set; }
        public short Series { get; set; }
        public string WorkflowClass { get; set; }
        public string Winname { get; set; }
        public string WorkflowManagers { get; set; }
        public string FieldsListGuid { get; set; }
        public string WfTypeBusObjKey { get; set; }
        public string WfTypeHistBusObjKey { get; set; }
        public decimal Noteindx { get; set; }
        public string DocAttachBusObjKeyFuncti { get; set; }
        public string DocumentDrillDownFunctio { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
