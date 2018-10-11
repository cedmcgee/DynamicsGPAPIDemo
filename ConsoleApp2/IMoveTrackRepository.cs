using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface IMoveTrackRepository
    {
        IEnumerable<Client> GetClients();
        IEnumerable<Invoice> GetInvoices(DateTime fromDate, DateTime toDate, string clientID);
        Invoice GetInvoice(DateTime fromDate, DateTime toDate, string clientID);
        IEnumerable<ARInvoiceLine> GetInvoiceLines(string aRInvoiceNo, bool IsPosted);
        IEnumerable<InvoiceVoucher> GetInvoiceVouchers(string aRInvoiceNo);
        IEnumerable<InvoiceVoucherLine> GetInvoiceVoucherLines(string voucherNumber);
        IEnumerable<AuthAsVendor> GetAuthorizationAsVendors(string authorizationId);
        IEnumerable<Item> GetItems();
        IEnumerable<Customer> GetCustomers();
        IEnumerable<Vendor> GetVendors();
        PaymentMethod GetPaymentMethod(string clientCode, string arCheckNo);
    }
}
