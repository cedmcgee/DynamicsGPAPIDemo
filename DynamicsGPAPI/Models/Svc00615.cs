using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00615
    {
        public string Userid { get; set; }
        public short Consts { get; set; }
        public string Contnbr { get; set; }
        public string Cnttype { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Lstbldte { get; set; }
        public DateTime Nxtbldte { get; set; }
        public decimal Totbil { get; set; }
        public decimal LastAmountBilled { get; set; }
        public decimal InvoicedAmount { get; set; }
        public string Custnmbr { get; set; }
        public string Adrscode { get; set; }
        public byte Mkdtopst { get; set; }
        public byte Posted { get; set; }
        public decimal Origtotbil { get; set; }
        public decimal OriglastamountBilled { get; set; }
        public decimal OrigInvoicedAmount { get; set; }
        public short Ermsgnbr { get; set; }
        public string Ermsgtxt { get; set; }
        public string Ermsgtx2 { get; set; }
        public string BillToCustomer { get; set; }
        public string SvcBillToAddressCode { get; set; }
        public byte SvcConsolidateContractIn { get; set; }
        public int DexRowId { get; set; }
    }
}
