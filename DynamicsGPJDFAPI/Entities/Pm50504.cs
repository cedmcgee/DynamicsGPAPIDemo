using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pm50504
    {
        public DateTime Pstgdate { get; set; }
        public string Vendorid { get; set; }
        public string Trxsorce { get; set; }
        public string Vchrnmbr { get; set; }
        public string Docnumbr { get; set; }
        public string Strval { get; set; }
        public string TrxId { get; set; }
        public decimal Acctamnt { get; set; }
        public short Cntrltyp { get; set; }
        public int DexRowId { get; set; }
    }
}
