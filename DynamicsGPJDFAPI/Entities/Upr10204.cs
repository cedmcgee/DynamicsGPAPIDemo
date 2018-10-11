using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Upr10204
    {
        public string Deprtmnt { get; set; }
        public string Jobtitle { get; set; }
        public string Userid { get; set; }
        public short Pyrntype { get; set; }
        public string Employid { get; set; }
        public int Trxnumber { get; set; }
        public string Deducton { get; set; }
        public byte Txshanty { get; set; }
        public short Dednsqnc { get; set; }
        public byte Vardedtn { get; set; }
        public decimal Vardbamt { get; set; }
        public int Vardbpct { get; set; }
        public short Dednfreq { get; set; }
        public decimal Ttldedtn { get; set; }
        public string Bchsourc { get; set; }
        public int Prtrxsrc { get; set; }
        public string Lastuser { get; set; }
        public DateTime Lstdtedt { get; set; }
        public DateTime Trxbegdt { get; set; }
        public DateTime Trxenddt { get; set; }
        public byte[] Bldchwrg { get; set; }
        public byte[] Bldcherr { get; set; }
        public short Dednmthd { get; set; }
        public short Prcssqnc { get; set; }
        public int Seqcount { get; set; }
        public decimal Sequencesum { get; set; }
        public byte[] Calcchkwrn { get; set; }
        public decimal Attemptedamt { get; set; }
        public short Splitmthd { get; set; }
        public decimal Maxamount { get; set; }
        public decimal Basedonwages { get; set; }
        public int DexRowId { get; set; }
    }
}
