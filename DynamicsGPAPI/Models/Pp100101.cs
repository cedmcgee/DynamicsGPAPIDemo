using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pp100101
    {
        public short PpModule { get; set; }
        public short PpRecordType { get; set; }
        public string PpDocumentNumber { get; set; }
        public int PpSequencer { get; set; }
        public int Ppoffseq { get; set; }
        public string Vchrnmbr { get; set; }
        public short Cntrltyp { get; set; }
        public int Dstsqnum { get; set; }
        public string Dscriptn { get; set; }
        public DateTime Glpostdt { get; set; }
        public decimal Trxamnt { get; set; }
        public int Jrnentry { get; set; }
        public int DexRowId { get; set; }
    }
}
