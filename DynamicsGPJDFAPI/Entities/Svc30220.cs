using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc30220
    {
        public short Srvrectype { get; set; }
        public string Callnbr { get; set; }
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; }
        public decimal InvoicedAmount { get; set; }
        public decimal AmountToInvoice { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Createtime { get; set; }
        public int DexRowId { get; set; }
    }
}
