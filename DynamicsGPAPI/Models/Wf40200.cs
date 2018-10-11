using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Wf40200
    {
        public string UsersListGuid { get; set; }
        public decimal Sequence1 { get; set; }
        public short WorkflowSelectionType { get; set; }
        public string AdobjectGuid { get; set; }
        public string AddistinguishedName { get; set; }
        public string AddisplayName { get; set; }
        public string Adalias { get; set; }
        public string Addomain { get; set; }
        public string Adlogin { get; set; }
        public string Email { get; set; }
        public short Adtype { get; set; }
        public short WorkflowRoleId { get; set; }
        public string WorkflowRole { get; set; }
        public short WorkflowHierarchyId { get; set; }
        public string WorkflowHierarchy { get; set; }
        public short HierarchyLevel { get; set; }
        public int DexRowId { get; set; }
    }
}
