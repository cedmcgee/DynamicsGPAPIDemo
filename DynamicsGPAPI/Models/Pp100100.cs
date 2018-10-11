﻿using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pp100100
    {
        public short PpModule { get; set; }
        public short PpRecordType { get; set; }
        public string PpDocumentNumber { get; set; }
        public int PpSequencer { get; set; }
        public int Ppoffseq { get; set; }
        public string Vchrnmbr { get; set; }
        public short Cntrltyp { get; set; }
        public int Dstsqnum { get; set; }
        public DateTime Strtngdt { get; set; }
        public DateTime Endingdt { get; set; }
        public int Offacct { get; set; }
        public int Actindx { get; set; }
        public int PpDeferredBcIndex { get; set; }
        public int PpDeferralsTransferIn { get; set; }
        public int PpRecognitionIndex { get; set; }
        public decimal Trxamnt { get; set; }
        public string Userid { get; set; }
        public string Refrence { get; set; }
        public short IntegerValue { get; set; }
        public short PpCalculationMethod { get; set; }
        public short PpMiscellaneousPeriods { get; set; }
        public short Voidstts { get; set; }
        public string Custvndr { get; set; }
        public DateTime Docdate { get; set; }
        public decimal Noteindx { get; set; }
        public int Jrnentry { get; set; }
        public int DexRowId { get; set; }
    }
}
