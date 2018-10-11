using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pop10800
    {
        public string Poprctnm { get; set; }
        public string Ponumber { get; set; }
        public string Pmntnmbr { get; set; }
        public decimal Appldamt { get; set; }
        public decimal Orappamt { get; set; }
        public decimal Distknam { get; set; }
        public decimal Ordistkn { get; set; }
        public int PrepaymentAccountIndex { get; set; }
        public decimal PrepaymentAmount { get; set; }
        public decimal OriginatingPrepaymentAmt { get; set; }
        public short Pstgstus { get; set; }
        public string Bachnumb { get; set; }
        public string Bchsourc { get; set; }
        public string Trxsorce { get; set; }
        public DateTime Glpostdt { get; set; }
        public byte Voided { get; set; }
        public int DexRowId { get; set; }
    }
}
