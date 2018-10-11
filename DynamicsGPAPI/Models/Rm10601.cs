using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Rm10601
    {
        public string Bachnumb { get; set; }
        public short Rmdtypal { get; set; }
        public string Docnumbr { get; set; }
        public string Custnmbr { get; set; }
        public string Taxdtlid { get; set; }
        public string Trxsorce { get; set; }
        public int Actindx { get; set; }
        public byte Bkouttax { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Ortaxamt { get; set; }
        public decimal Staxamnt { get; set; }
        public decimal Orslstax { get; set; }
        public decimal Frttxamt { get; set; }
        public decimal Orfrttax { get; set; }
        public decimal Msctxamt { get; set; }
        public decimal Ormsctax { get; set; }
        public decimal Taxdtsls { get; set; }
        public decimal Ortotsls { get; set; }
        public decimal Tdttxsls { get; set; }
        public decimal Ortxsls { get; set; }
        public byte Posted { get; set; }
        public int Seqnumbr { get; set; }
        public short Currnidx { get; set; }
        public int DexRowId { get; set; }
    }
}
