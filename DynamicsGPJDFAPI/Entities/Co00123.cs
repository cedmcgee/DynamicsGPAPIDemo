using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Co00123
    {
        public string FieldsListGuid { get; set; }
        public string ConditionsGuid { get; set; }
        public int Seqnumbr { get; set; }
        public string FromTable { get; set; }
        public string FromField { get; set; }
        public short FromDictId { get; set; }
        public int FromFieldListSequence { get; set; }
        public string ToTable { get; set; }
        public string ToField { get; set; }
        public short ToDictId { get; set; }
        public int ToFieldListSequence { get; set; }
        public short FieldDataType { get; set; }
        public byte FieldComparison { get; set; }
        public short QueryOperator { get; set; }
        public short QueryConditon { get; set; }
        public string StringFilter1 { get; set; }
        public string StringFilter2 { get; set; }
        public int IntegerFilter1 { get; set; }
        public int IntegerFilter2 { get; set; }
        public decimal NumericFilter1 { get; set; }
        public decimal NumericFilter2 { get; set; }
        public DateTime DateFilter1 { get; set; }
        public DateTime DateFilter2 { get; set; }
        public DateTime TimeFilter1 { get; set; }
        public DateTime TimeFilter2 { get; set; }
        public string EnumFilter { get; set; }
        public int DexRowId { get; set; }
    }
}
