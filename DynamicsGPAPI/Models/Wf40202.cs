using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Wf40202
    {
        public string WorkflowTypeName { get; set; }
        public short EmailMessageType { get; set; }
        public int Seqnumbr { get; set; }
        public int OrdLine { get; set; }
        public short WfTemplateFieldType { get; set; }
        public short TableSeries { get; set; }
        public short TableDictId { get; set; }
        public string Rsrcid { get; set; }
        public string TablePhysicalName { get; set; }
        public string FieldPhysicalName { get; set; }
        public string FieldName { get; set; }
        public short FieldDataType { get; set; }
        public short TableRelationship { get; set; }
        public byte AdditionalFields { get; set; }
        public int DexRowId { get; set; }
    }
}
