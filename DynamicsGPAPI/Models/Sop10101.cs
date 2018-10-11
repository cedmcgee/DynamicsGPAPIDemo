using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sop10101
    {
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; }
        public int Seqnumbr { get; set; }
        public string Slprsnid { get; set; }
        public string Salsterr { get; set; }
        public short Comprcnt { get; set; }
        public decimal Commamnt { get; set; }
        public decimal Ocommamt { get; set; }
        public decimal Ncomamnt { get; set; }
        public decimal Orncmamt { get; set; }
        public short Prctosal { get; set; }
        public decimal Actslamt { get; set; }
        public decimal Orslsamt { get; set; }
        public decimal Cmmslamt { get; set; }
        public decimal Orcosamt { get; set; }
        public short Currnidx { get; set; }
        public string Trxsorce { get; set; }
        public int DexRowId { get; set; }
    }
}
