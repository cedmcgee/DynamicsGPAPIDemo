using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Upr10205
    {
        public string Deprtmnt { get; set; }
        public string Jobtitle { get; set; }
        public string Userid { get; set; }
        public short Pyrntype { get; set; }
        public string Employid { get; set; }
        public int Trxnumber { get; set; }
        public string Benefit { get; set; }
        public byte Taxable { get; set; }
        public byte Varbenft { get; set; }
        public decimal Vardbamt { get; set; }
        public int Vardbpct { get; set; }
        public short Bnftfreq { get; set; }
        public decimal Totlbnft { get; set; }
        public decimal Amtbotip { get; set; }
        public string Bchsourc { get; set; }
        public int Prtrxsrc { get; set; }
        public string Lastuser { get; set; }
        public DateTime Lstdtedt { get; set; }
        public DateTime Trxbegdt { get; set; }
        public DateTime Trxenddt { get; set; }
        public byte[] Bldchwrg { get; set; }
        public byte[] Bldcherr { get; set; }
        public short Bnftmthd { get; set; }
        public short Prcssqnc { get; set; }
        public int DexRowId { get; set; }
    }
}
