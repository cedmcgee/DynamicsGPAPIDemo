using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class PaymentMethodDetail
    {
        public int expId { get; set; }
        public string expCode { get; set; }
        public string expDesc { get; set; }
        public decimal arIvnAmt { get; set; }
        public decimal arPaidAmt { get; set; }
        public decimal arWriteOffAmt { get; set; }
        public DateTime arPaidDate { get; set; }
    }
}
