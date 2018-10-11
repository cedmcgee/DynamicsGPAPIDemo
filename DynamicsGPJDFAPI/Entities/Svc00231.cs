using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00231
    {
        public short Srvrectype { get; set; }
        public string Callnbr { get; set; }
        public int Eqpline { get; set; }
        public int Lnitmseq { get; set; }
        public string Linitmtyp { get; set; }
        public int Seqnumbr { get; set; }
        public short SvcDistributionType { get; set; }
        public string DistRef { get; set; }
        public int Actindx { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Ordbtamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Orcrdamt { get; set; }
        public short Currnidx { get; set; }
        public string Trxsorce { get; set; }
        public byte Posted { get; set; }
        public DateTime Posteddt { get; set; }
        public int Cmpntseq { get; set; }
        public int DexRowId { get; set; }
    }
}
