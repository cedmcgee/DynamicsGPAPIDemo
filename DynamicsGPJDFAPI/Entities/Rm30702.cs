using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Rm30702
    {
        public int Rnnmbr { get; set; }
        public string Custnmbr { get; set; }
        public string Dscriptn { get; set; }
        public string Curncyid { get; set; }
        public int Seqnumbr { get; set; }
        public short Currnidx { get; set; }
        public DateTime Docdate { get; set; }
        public string Docnumbr { get; set; }
        public string Docprfix { get; set; }
        public short Rmdtypal { get; set; }
        public string Docdescr { get; set; }
        public string Pordnmbr { get; set; }
        public decimal Docamnt { get; set; }
        public string CreditAmountString30 { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Balncdue { get; set; }
        public short Agngbukt { get; set; }
        public decimal Crdtamnt { get; set; }
        public string Chcumnum { get; set; }
        public string Chcumnam { get; set; }
        public decimal Curtrxam { get; set; }
        public decimal Amntpaid { get; set; }
        public int DexRowId { get; set; }
    }
}
