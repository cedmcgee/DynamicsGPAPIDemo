using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pop10390
    {
        public string Poprctnm { get; set; }
        public int Seqnumbr { get; set; }
        public int Actindx { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Orcrdamt { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Ordbtamt { get; set; }
        public string DistRef { get; set; }
        public short Disttype { get; set; }
        public string Trxsorce { get; set; }
        public short Currnidx { get; set; }
        public decimal Xchgrate { get; set; }
        public string Vendorid { get; set; }
        public string Curncyid { get; set; }
        public string Ratetpid { get; set; }
        public string Exgtblid { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Ratecalc { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public int DexRowId { get; set; }
    }
}
