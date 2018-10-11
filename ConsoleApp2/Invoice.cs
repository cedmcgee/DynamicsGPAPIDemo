using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Invoice
    {
        public string ClientCode { get; set; }
        public string ARInvoiceNbr { get; set; }
        public DateTime ARInvoiceDate { get; set; }
        public decimal Total { get; set; }
    }
}
