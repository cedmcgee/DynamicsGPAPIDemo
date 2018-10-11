using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc35210
    {
        public short ReturnRecordType { get; set; }
        public string Retdocid { get; set; }
        public decimal Lnseqnbr { get; set; }
        public decimal SvcProcessSeqNumber { get; set; }
        public int Sltsqnum { get; set; }
        public decimal ReturnQty { get; set; }
        public decimal SvcProcessQty { get; set; }
        public short SvcProcessType { get; set; }
        public short ReturnDispositionStatu { get; set; }
        public string SvcProcessStatus { get; set; }
        public string SvcDocumentNumber { get; set; }
        public decimal SvcIvSeqNumber { get; set; }
        public int Cmpntseq { get; set; }
        public short Qtytype { get; set; }
        public int DexRowId { get; set; }
    }
}
