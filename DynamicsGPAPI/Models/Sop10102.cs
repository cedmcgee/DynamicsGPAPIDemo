using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sop10102
    {
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; }
        public int Seqnumbr { get; set; }
        public short Disttype { get; set; }
        public string DistRef { get; set; }
        public int Actindx { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Ordbtamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Orcrdamt { get; set; }
        public short Currnidx { get; set; }
        public string Trxsorce { get; set; }
        public byte Posted { get; set; }
        public decimal ContractExchangeRate { get; set; }
        public int DexRowId { get; set; }
    }
}
