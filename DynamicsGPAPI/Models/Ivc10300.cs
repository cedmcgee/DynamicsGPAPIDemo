using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Ivc10300
    {
        public short Doctype { get; set; }
        public string Invcnmbr { get; set; }
        public int Seqnumbr { get; set; }
        public short Disttype { get; set; }
        public string DistRef { get; set; }
        public int Actindx { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public string Trxsorce { get; set; }
        public byte Posted { get; set; }
        public int DexRowId { get; set; }
    }
}
