using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc05003
    {
        public string RtvType { get; set; }
        public string Dscriptn { get; set; }
        public string Itlocn { get; set; }
        public string Locncode { get; set; }
        public string RtvReturnStatus { get; set; }
        public string RtvShippingStatus { get; set; }
        public string RtvReceivedStatus { get; set; }
        public string RtvClosedStatus { get; set; }
        public short RtvRouting { get; set; }
        public int SvcPurchaseIndex { get; set; }
        public int SvcCostIndex { get; set; }
        public int SvcReimbursementIndex { get; set; }
        public string SvcReadyToShipStatus { get; set; }
        public string SvcPartialShippedStat { get; set; }
        public string SvcPartialReceivedSta { get; set; }
        public int DexRowId { get; set; }
    }
}
