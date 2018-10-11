using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc05625
    {
        public string Userid { get; set; }
        public string RtvNumber { get; set; }
        public decimal RtvLine { get; set; }
        public string RtvType { get; set; }
        public string Offid { get; set; }
        public string Vendorid { get; set; }
        public string Adrscode { get; set; }
        public string Vendname { get; set; }
        public string Locncode { get; set; }
        public string Itemnmbr { get; set; }
        public decimal Quantity { get; set; }
        public decimal Qtyshppd { get; set; }
        public decimal QtyToReceive { get; set; }
        public decimal Qtyrecvd { get; set; }
        public string Vnditnum { get; set; }
        public string ReturnItemNumber { get; set; }
        public string TransferReference { get; set; }
        public int Translineseq { get; set; }
        public byte Mkdtopst { get; set; }
        public byte Posted { get; set; }
        public short Ermsgnbr { get; set; }
        public string Ermsgtxt { get; set; }
        public int DexRowId { get; set; }
    }
}
