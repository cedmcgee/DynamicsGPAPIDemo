using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag2000t
    {
        public byte Voided { get; set; }
        public int Dstsqnum { get; set; }
        public int Actindx { get; set; }
        public short Accttype { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public string DistRef { get; set; }
        public decimal Orcrdamt { get; set; }
        public decimal Ordbtamt { get; set; }
        public int DexRowId { get; set; }
    }
}
