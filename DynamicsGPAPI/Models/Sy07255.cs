using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sy07255
    {
        public int ActionStatusId { get; set; }
        public int Ord { get; set; }
        public string Ermsgtxt { get; set; }
        public int Errval { get; set; }
        public string Refrence { get; set; }
        public DateTime UserDefinedDate01 { get; set; }
        public DateTime UserDefinedDate02 { get; set; }
        public int UserDefinedLongInt01 { get; set; }
        public int UserDefinedLongInt02 { get; set; }
        public string UserDefinedText01 { get; set; }
        public string UserDefinedText02 { get; set; }
        public string UserDefinedText03 { get; set; }
        public string UserDefinedText04 { get; set; }
        public string UserDefinedText05 { get; set; }
        public byte Verified { get; set; }
        public int DexRowId { get; set; }
    }
}
