using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Me142803
    {
        public string Mebankid { get; set; }
        public string Mebankdesc { get; set; }
        public short MeFileType { get; set; }
        public string MeDelimiter { get; set; }
        public short MeRecordLength { get; set; }
        public short MeFromPosition { get; set; }
        public short MeToPosition { get; set; }
        public short MeFieldNumber { get; set; }
        public byte MeUsesStatusCodes { get; set; }
        public DateTime Userdate { get; set; }
        public string Userid { get; set; }
        public short MeFileFormat { get; set; }
        public byte MeRecordDelimiter { get; set; }
        public int DexRowId { get; set; }
    }
}
