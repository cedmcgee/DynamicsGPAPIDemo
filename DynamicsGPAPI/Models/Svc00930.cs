using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00930
    {
        public string WorkType { get; set; }
        public byte BillableWork { get; set; }
        public string Dscriptn { get; set; }
        public byte SvcPostToPayroll { get; set; }
        public string Payrcord { get; set; }
        public int DexRowId { get; set; }
    }
}
