using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ARInvoiceLine
    {
        public int ExpID { get; set; }
        public string Customer { get; set; }
        public string AuthorizationID { get; set; }
        public string VoucherNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime ExpDate { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime PostDate { get; set; }
        public string ExpDesc { get; set; }
        public string GLCode { get; set; }
        public string GLDesc { get; set; }
        public decimal ARInvAmt { get; set; }
        public int VoucherType { get; set; }
        public decimal Markup { get; set; }
    }
}
