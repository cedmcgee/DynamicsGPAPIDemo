using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Gl40000
    {
        public string Uniqkey { get; set; }
        public int Njrnlent { get; set; }
        public int Rerindx { get; set; }
        public DateTime Lstclsdt { get; set; }
        public byte Trerclsg { get; set; }
        public short Divactsg { get; set; }
        public short Blncdspl { get; set; }
        public byte Kpgachst { get; set; }
        public byte Kpgtrxhs { get; set; }
        public byte Ahstpstg { get; set; }
        public string Usrdfpr1 { get; set; }
        public string Usrdrpr2 { get; set; }
        public string Usrdrpr3 { get; set; }
        public string Usrdrpr4 { get; set; }
        public byte Updtaccel { get; set; }
        public short PostingNumberType { get; set; }
        public byte DeleteSavedTrx { get; set; }
        public byte VoidSubTrx { get; set; }
        public byte CorrectIcTrx { get; set; }
        public byte AllowReportingLedgers { get; set; }
        public byte[] UseLedgersForAcctBalance { get; set; }
        public int Nxtbudjrlent { get; set; }
        public byte Kpbudtrxhist { get; set; }
        public int NextReconciliationNumber { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
