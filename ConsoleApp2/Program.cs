using System;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Newtonsoft.Json;
using System.Security;
using System.Security.Cryptography;
using System.Runtime.Caching;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //MemoryCache memoryCache = MemoryCache.Default;
            //List<Vendor> cacheVendors = (List<Vendor>)MoveTrackAPIFactory.ExecuteService("selectvendors", typeof(List<Vendor>));

            //string username = "MBrimage", password = "Ireland1";

            //var cacheItemPolicy = new CacheItemPolicy()
            //{
            //    AbsoluteExpiration = DateTime.Now.AddDays(1)
            //};

            //memoryCache.Add("Vendors", cacheVendors, new CacheItemPolicy { AbsoluteExpiration = DateTime.Now.AddDays(1) });

            //var textToEncode = Encoding.UTF8.GetBytes("Flood2Versa!");
            // System.Configuration.ConfigurationSettings
            // ConfigurationSettings.AppSettings["username"];


            //  var encodedText = Convert.ToBase64String(textToEncode);
            // var credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(String.Format("{0}:{1}", ConfigurationManager.AppSettings["mtusername"], ConfigurationManager.AppSettings["mtpassword"])));
            // var webclient = new WebClient();//  { Credentials = new NetworkCredential(username,password) };

            // webclient.Headers[HttpRequestHeader.Authorization] = String.Format("Basic {0}", credentials);
            // var response = webclient.DownloadDataAsync()
            // var response = webclient.DownloadString(String.Format("{0}GetItems",ConfigurationManager.AppSettings["ineoUrl"]));
            // List<Item>
            // List<Item> items
            // List<Item> respObj = JsonConvert.DeserializeObject<List<Item>>(response);
            // List<Vendor> retrievedVendors = (List<Vendor>)memoryCache.Get("Vendors");
            // if (!memoryCache.Contains("Vendors")) {   } 
            
                List<Item> items = (List<Item>)MoveTrackAPIFactory.ExecuteService("GetItems", typeof(List<Item>));
            Item item = items.Find(p => p.expenseCode.Equals("510"));

            
            // List<Customer> customers = (List<Customer>)MoveTrackAPIFactory.ExecuteService("GetCustomers", typeof(List<Customer>));
                // foreach(Customer c  in customers.OrderBy(p => p.clientCode,)
               
                // List<Vendor> vendors = (List<Vendor>)MoveTrackAPIFactory.ExecuteService("selectvendors", typeof(List<Vendor>));
                // List<Client> clients = (List <Client>)MoveTrackAPIFactory.ExecuteService("getclients", typeof(List<Client>));
                // List<PaymentMethod> paymentMethods = (List<PaymentMethod>)MoveTrackAPIFactory.ExecuteService(String.Format("getpaymentmethods?ClientCode={0}&ARCheckNo={1}", "MUSTANG", "wire"), typeof(List<PaymentMethod>));
                // List <Invoice> invoices = (List<Invoice>)MoveTrackAPIFactory.ExecuteService(String.Format("getinvoice?ARInvoiceNo={0}","13"), typeof(List<Invoice>));
                // List<InvoiceVoucher> invoiceVouchers = (List<InvoiceVoucher>)MoveTrackAPIFactory.ExecuteService(String.Format("getinvoicevouchers?VoucherNumber={0}", "3900"), typeof(List<InvoiceVoucher>));
                // List<CheckAmount> checkAmount = (List<CheckAmount>)MoveTrackAPIFactory.ExecuteService(String.Format("getcheckamount?VoucherNumber={0}", "20"), typeof(List<CheckAmount>));
                // List<Invoice> clientInvoices = (List<Invoice>)MoveTrackAPIFactory.ExecuteService(String.Format("getinvoices?fromDate={0}&toDate={1}&clientID={2}","12/4/2017","1/3/2018","NATIONAL"),typeof(List<Invoice>));



                //  Client client = clients.Where(s => s.ClientID.Equals(13)).First();
               
                 

           Console.Read();
            
        }
    }
}
