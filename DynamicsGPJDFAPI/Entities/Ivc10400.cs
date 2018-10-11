using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Ivc10400
    {
        public short Doctype { get; set; }
        public string Invcnmbr { get; set; }
        public int Seqnumbr { get; set; }
        public string Slprsnid { get; set; }
        public string Salsterr { get; set; }
        public short Comprcnt { get; set; }
        public decimal Comdlram { get; set; }
        public decimal Ncomamnt { get; set; }
        public short Prctosal { get; set; }
        public decimal Slsamnt { get; set; }
        public string Commcode { get; set; }
        public string Trxsorce { get; set; }
        public short Commflag { get; set; }
        public short Actvtype { get; set; }
        public int DexRowId { get; set; }
    }
}
