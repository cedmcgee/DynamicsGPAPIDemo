using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Co00122
    {
        public string FieldsListGuid { get; set; }
        public int GroupId { get; set; }
        public int Seqnumbr { get; set; }
        public short FromDictId { get; set; }
        public string FromTable { get; set; }
        public string FromTablePhysicalName { get; set; }
        public string FromField { get; set; }
        public string FromFieldPhysicalName { get; set; }
        public short ToDictId { get; set; }
        public string ToTable { get; set; }
        public string ToTablePhysicalName { get; set; }
        public string ToField { get; set; }
        public string ToFieldPhysicalName { get; set; }
        public short JoinType { get; set; }
        public int DexRowId { get; set; }
    }
}
