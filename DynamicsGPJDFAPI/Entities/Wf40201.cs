using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Wf40201
    {
        public string WorkflowTypeName { get; set; }
        public short WorkflowRoleId { get; set; }
        public string WorkflowRole { get; set; }
        public short WorkflowRoleTable { get; set; }
        public short TableDictId { get; set; }
        public string TablePhysicalName { get; set; }
        public string FieldPhysicalName { get; set; }
        public short TableRelationship { get; set; }
        public int DexRowId { get; set; }
    }
}
