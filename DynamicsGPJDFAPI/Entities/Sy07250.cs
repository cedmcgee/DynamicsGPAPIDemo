using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sy07250
    {
        public string Userid { get; set; }
        public short ListDictId { get; set; }
        public short ListId { get; set; }
        public int ViewId { get; set; }
        public int ActionId { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public string ActionName { get; set; }
        public int SuccessCount { get; set; }
        public int FailureCount { get; set; }
        public int ActionStatusId { get; set; }
        public int DexRowId { get; set; }
    }
}
