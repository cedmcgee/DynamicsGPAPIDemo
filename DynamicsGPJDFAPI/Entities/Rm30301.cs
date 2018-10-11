using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Rm30301
    {
        public string Trxsorce { get; set; }
        public DateTime Posteddt { get; set; }
        public string Docnumbr { get; set; }
        public short Disttype { get; set; }
        public short Rmdtypal { get; set; }
        public int Seqnumbr { get; set; }
        public string Custnmbr { get; set; }
        public int Dstindx { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public string Projctid { get; set; }
        public string Userid { get; set; }
        public short Categusd { get; set; }
        public string Curncyid { get; set; }
        public short Currnidx { get; set; }
        public decimal Orcrdamt { get; set; }
        public decimal Ordbtamt { get; set; }
        public string DistRef { get; set; }
        public int DexRowId { get; set; }
    }
}
