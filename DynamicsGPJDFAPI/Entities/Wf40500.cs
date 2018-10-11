using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Wf40500
    {
        public string UsersListGuid { get; set; }
        public string DomainUserName { get; set; }
        public string AddisplayName { get; set; }
        public byte WfAutoDelegateTasks { get; set; }
        public short WorkflowSelectDelegate { get; set; }
        public int DexRowId { get; set; }
    }
}
