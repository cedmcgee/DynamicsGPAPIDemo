using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pp000001
    {
        public string Uniqkey { get; set; }
        public string Sourcdoc { get; set; }
        public string Trxsrcpx { get; set; }
        public int Ntrxsnum { get; set; }
        public string PpDocumentNumber { get; set; }
        public short PpOpenClosedPeriods { get; set; }
        public short PpAutoPost { get; set; }
        public short PpAutoPostBack { get; set; }
        public short PpRmInitialPosting { get; set; }
        public short PpPmInitialPosting { get; set; }
        public short PpCalculationMethod { get; set; }
        public byte Ppprtrpt { get; set; }
        public byte Ppprtprt { get; set; }
        public byte Ppprtscn { get; set; }
        public byte Prntofil { get; set; }
        public short PpVoidTrns { get; set; }
        public short PpOverideAccess { get; set; }
        public short PpProfileAccountOverw { get; set; }
        public int DexRowId { get; set; }
    }
}
