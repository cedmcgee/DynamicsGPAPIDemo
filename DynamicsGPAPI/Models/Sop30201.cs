using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sop30201
    {
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; }
        public int Lnitmseq { get; set; }
        public string Custnmbr { get; set; }
        public string Custname { get; set; }
        public DateTime Docdate { get; set; }
        public string Docnumbr { get; set; }
        public short Rmdtypal { get; set; }
        public short Pymttype { get; set; }
        public decimal Amntpaid { get; set; }
        public decimal Oamtpaid { get; set; }
        public string Chekbkid { get; set; }
        public string Cheknmbr { get; set; }
        public string Cardname { get; set; }
        public string Rctnccrd { get; set; }
        public DateTime Expndate { get; set; }
        public string Authcode { get; set; }
        public DateTime Pymntdat { get; set; }
        public DateTime Glpostdt { get; set; }
        public int Cashindex { get; set; }
        public int Depindex { get; set; }
        public byte Delete1 { get; set; }
        public string Curncyid { get; set; }
        public short Currnidx { get; set; }
        public decimal Xchgrate { get; set; }
        public decimal Denxrate { get; set; }
        public string Ratetpid { get; set; }
        public short Rtclcmtd { get; set; }
        public string Exgtblid { get; set; }
        public DateTime Exchdate { get; set; }
        public short Mctrxstt { get; set; }
        public DateTime Time1 { get; set; }
        public string Trxsorce { get; set; }
        public int DexRowId { get; set; }
    }
}
