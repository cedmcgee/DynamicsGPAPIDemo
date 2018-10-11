using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc05501
    {
        public string Rettype { get; set; }
        public string Dscriptn { get; set; }
        public string Retstat { get; set; }
        public string ReceivedStatus { get; set; }
        public string ShippingStatus { get; set; }
        public string CloseStatus { get; set; }
        public short Retpath { get; set; }
        public string Vndwarrtype { get; set; }
        public string RtvType { get; set; }
        public string Depottype { get; set; }
        public string Orddocid { get; set; }
        public string Crdocid { get; set; }
        public string Invdocid { get; set; }
        public string Locncode { get; set; }
        public string Itlocn { get; set; }
        public string Itemnmbr { get; set; }
        public string SvcDiscrepancyStatus { get; set; }
        public string SvcRmaInvoiceBatchId { get; set; }
        public string SvcRmaCreditBatchId { get; set; }
        public string SvcRmaOrderBatchId { get; set; }
        public int SvcSalesReturnIndex { get; set; }
        public int SvcCogsIndex { get; set; }
        public int SvcScrapIndex { get; set; }
        public int SvcRepairSalesIndex { get; set; }
        public string SvcPartialReceivedSta { get; set; }
        public string SvcReadyToCloseStatu { get; set; }
        public byte Svcscrapcogrev { get; set; }
        public short Qtytype { get; set; }
        public int DexRowId { get; set; }
    }
}
