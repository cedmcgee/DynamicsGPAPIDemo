using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc05115
    {
        public string Userid { get; set; }
        public string Retdocid { get; set; }
        public decimal Lnseqnbr { get; set; }
        public string Rettype { get; set; }
        public string Offid { get; set; }
        public string Techid { get; set; }
        public string Custnmbr { get; set; }
        public string Adrscode { get; set; }
        public string Custname { get; set; }
        public string ReturnItemNumber { get; set; }
        public decimal ReturnQty { get; set; }
        public decimal RepairCost { get; set; }
        public decimal RepairPrice { get; set; }
        public decimal OriginatingRepairCost { get; set; }
        public decimal OriginatingRepairPrice { get; set; }
        public byte Mkdtopst { get; set; }
        public byte Posted { get; set; }
        public short Ermsgnbr { get; set; }
        public string Ermsgtxt { get; set; }
        public string Ermsgtx2 { get; set; }
        public byte Prntdtld { get; set; }
        public string SvcBillToAddressCode { get; set; }
        public string Cstponbr { get; set; }
        public int DexRowId { get; set; }
    }
}
