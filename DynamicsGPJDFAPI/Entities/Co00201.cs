using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Co00201
    {
        public short Series { get; set; }
        public string Userid { get; set; }
        public short Typeid { get; set; }
        public int Seqnumbr { get; set; }
        public byte Option1 { get; set; }
        public byte Option2 { get; set; }
        public byte Option3 { get; set; }
        public byte Option4 { get; set; }
        public string FieldPhysicalName { get; set; }
        public short FieldDataType { get; set; }
        public short FieldRefId { get; set; }
        public short FilterType { get; set; }
        public string StartPositionString { get; set; }
        public string EndPositionString { get; set; }
        public decimal Strtamnt { get; set; }
        public decimal Endamnt { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public int StartValue { get; set; }
        public int EndValue { get; set; }
        public int DexRowId { get; set; }
    }
}
