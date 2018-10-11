using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MoveTrackRepository : IMoveTrackRepository
    {
        private IMoveTrackRepository _rep;
        public MoveTrackRepository(IMoveTrackRepository rep) { _rep = rep; }
        public IEnumerable<AuthAsVendor> GetAuthorizationAsVendors(string authorizationId)
        {
            return _rep.GetAuthorizationAsVendors(authorizationId);
        }

        public IEnumerable<Client> GetClients()
        {
            return _rep.GetClients();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public Invoice GetInvoice(DateTime fromDate, DateTime toDate, string clientID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ARInvoiceLine> GetInvoiceLines(string aRInvoiceNo, bool IsPosted)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Invoice> GetInvoices(DateTime fromDate, DateTime toDate, string clientID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InvoiceVoucherLine> GetInvoiceVoucherLines(string voucherNumber)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InvoiceVoucher> GetInvoiceVouchers(string aRInvoiceNo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetItems()
        {
            throw new NotImplementedException();
        }

        public PaymentMethod GetPaymentMethod(string clientCode, string arCheckNo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vendor> GetVendors()
        {
            throw new NotImplementedException();
        }
    }
}
