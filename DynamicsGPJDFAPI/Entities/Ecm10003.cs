using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Ecm10003
    {
        public string PoReqNo { get; set; }
        public int SeqOrdId { get; set; }
        public string ItemId { get; set; }
        public string ItemDesc { get; set; }
        public string VendItemId { get; set; }
        public string VendItemDesc { get; set; }
        public string VendId { get; set; }
        public string VendName { get; set; }
        public decimal CommitAmt { get; set; }
        public short PoOrReq { get; set; }
        public int DexRowId { get; set; }
    }
}
