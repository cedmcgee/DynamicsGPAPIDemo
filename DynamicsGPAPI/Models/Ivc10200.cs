using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Ivc10200
    {
        public short Doctype { get; set; }
        public string Invcnmbr { get; set; }
        public int Seqnumbr { get; set; }
        public short Pymttype { get; set; }
        public short Rmdtypal { get; set; }
        public string Docnumbr { get; set; }
        public string Curncyid { get; set; }
        public string Chekbkid { get; set; }
        public string Cardname { get; set; }
        public string Rctnccrd { get; set; }
        public string Cheknmbr { get; set; }
        public decimal Amntpaid { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime Expndate { get; set; }
        public string Authcode { get; set; }
        public string Trxsorce { get; set; }
        public byte Eftflag { get; set; }
        public int DexRowId { get; set; }
    }
}
