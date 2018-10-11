using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Mss10000
    {
        public short Series { get; set; }
        public short Doctype { get; set; }
        public string Docnumbr { get; set; }
        public int MssOrdPriKey { get; set; }
        public int MssAtpriKey { get; set; }
        public string MssOrderNo { get; set; }
        public string MssCustomerNumber2 { get; set; }
        public string MssAuthority { get; set; }
        public string MssNanumber { get; set; }
        public string MssDriver { get; set; }
        public string MssSalesPerson { get; set; }
        public int MssItemCode { get; set; }
        public string MssBranchCode { get; set; }
        public string MssInvoiceNumber { get; set; }
        public DateTime MssInvoiceDate { get; set; }
        public string MssItemCodeDesc { get; set; }
        public string MssServiceCode { get; set; }
        public string MssShipperName { get; set; }
        public int DexRowId { get; set; }
    }
}
