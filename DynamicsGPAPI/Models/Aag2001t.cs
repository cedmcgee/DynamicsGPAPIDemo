using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag2001t
    {
        public decimal Cmrecnum { get; set; }
        public string Depositnumber { get; set; }
        public short RcpType { get; set; }
        public string Rcptnmbr { get; set; }
        public decimal Rcptamt { get; set; }
        public string Bankname { get; set; }
        public string Bnkbrnch { get; set; }
        public byte Updated { get; set; }
        public byte Marked { get; set; }
        public DateTime Receiptdate { get; set; }
        public decimal CheckbookAmount { get; set; }
        public string Ratetpid { get; set; }
        public string Exgtblid { get; set; }
        public decimal Xchgrate { get; set; }
        public decimal ReceivingExchangeRate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public DateTime Expndate { get; set; }
        public decimal Rlganlos { get; set; }
        public string Curncyid { get; set; }
        public short Currnidx { get; set; }
        public short Decplcur { get; set; }
        public decimal Origamt { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public int DexRowId { get; set; }
    }
}
