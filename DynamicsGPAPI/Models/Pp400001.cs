using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pp400001
    {
        public string Bachnumb { get; set; }
        public string Bchsourc { get; set; }
        public short Series { get; set; }
        public short PpModule { get; set; }
        public short PpRecordType { get; set; }
        public string PpDocumentNumber { get; set; }
        public int PpSequencer { get; set; }
        public int Ppoffseq { get; set; }
        public decimal Trxamnt { get; set; }
        public byte PpSavedStatus { get; set; }
        public int DexRowId { get; set; }
    }
}
