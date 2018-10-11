using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class PaymentMethod
    {
        public string arInvoiceNo { get; set; }
        public string arInvAmt { get; set; }
        public ICollection<PaymentMethodDetail> InvoiceDetails { get; set; }  = new List<PaymentMethodDetail>(); 

    }
}
