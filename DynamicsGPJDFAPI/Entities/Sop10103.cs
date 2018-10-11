using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sop10103
    {
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; }
        public int Seqnumbr { get; set; }
        public short Pymttype { get; set; }
        public string Docnumbr { get; set; }
        public short Rmdtypal { get; set; }
        public string Chekbkid { get; set; }
        public string Cheknmbr { get; set; }
        public string Cardname { get; set; }
        public string Rctnccrd { get; set; }
        public string Authcode { get; set; }
        public decimal Amntpaid { get; set; }
        public decimal Oamtpaid { get; set; }
        public decimal Amntrema { get; set; }
        public decimal Oamntrem { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime Expndate { get; set; }
        public string Curncyid { get; set; }
        public short Currnidx { get; set; }
        public string Trxsorce { get; set; }
        public short Depstats { get; set; }
        public byte Delete1 { get; set; }
        public DateTime Glpostdt { get; set; }
        public int Cashindex { get; set; }
        public int Depindex { get; set; }
        public byte Eftflag { get; set; }
        public int DexRowId { get; set; }
    }
}
