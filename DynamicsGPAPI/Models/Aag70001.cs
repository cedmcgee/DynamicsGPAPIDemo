using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag70001
    {
        public string Userid { get; set; }
        public string Trxbtchsrc { get; set; }
        public short Series { get; set; }
        public int AaGlhdrId { get; set; }
        public int AaGldistId { get; set; }
        public int Actindx { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Ordbtamt { get; set; }
        public decimal Orcrdamt { get; set; }
        public string Curncyid { get; set; }
        public short Currnidx { get; set; }
        public int DexRowId { get; set; }
    }
}
