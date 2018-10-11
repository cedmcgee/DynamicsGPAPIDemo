using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Upr10206
    {
        public string Deprtmnt { get; set; }
        public string Jobtitle { get; set; }
        public string Userid { get; set; }
        public short Pyrntype { get; set; }
        public string Employid { get; set; }
        public int Trxnumber { get; set; }
        public string Statecd { get; set; }
        public decimal Ttlsttax { get; set; }
        public decimal Sttxtips { get; set; }
        public decimal Txblwags { get; set; }
        public decimal Txbltips { get; set; }
        public byte[] Bldcherr { get; set; }
        public int DexRowId { get; set; }
    }
}
