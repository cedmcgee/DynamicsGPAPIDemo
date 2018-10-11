using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pp000042
    {
        public short PpModule { get; set; }
        public short PpRecordType { get; set; }
        public int Ppoffseq { get; set; }
        public int PpSequencer { get; set; }
        public string PpDocumentNumber { get; set; }
        public string PpProfileName { get; set; }
        public int DexRowId { get; set; }
    }
}
