using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class InvoiceVoucher
    {
        public string VoucherNbr { get; set; }
        public string VoucherInvoiceNbr { get; set; }
        public string VoucherVendor { get; set; }
        public DateTime APPosted { get; set; }
        public DateTime APDate { get; set; }
        public int VoucherType { get; set; }
    }
}
