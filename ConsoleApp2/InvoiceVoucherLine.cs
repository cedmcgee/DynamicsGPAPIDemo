using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class InvoiceVoucherLine
    {
        public int expID { get; set; }
        public string vendor { get; set; }
        public string authorizationId { get; set; }
        public string voucherNo { get; set; }
        public int voucherType { get; set; }
        public DateTime expDate { get; set; }
        public DateTime docDate { get; set; }
        public DateTime postDate { get; set; }
        public string expCode { get; set; }
        public string expDesc { get; set; }
        public string glCode { get; set; }
        public string glDescr { get; set; }
        public decimal arInvAmt { get; set; }
        public decimal markUp { get; set; }

    }
}
