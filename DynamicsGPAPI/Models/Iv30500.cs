using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Iv30500
    {
        public short Ivdoctyp { get; set; }
        public string Docnumbr { get; set; }
        public string Itemnmbr { get; set; }
        public string Trxsorce { get; set; }
        public int Actindx { get; set; }
        public short Disttype { get; set; }
        public DateTime Posteddt { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public int DexRowId { get; set; }
    }
}
