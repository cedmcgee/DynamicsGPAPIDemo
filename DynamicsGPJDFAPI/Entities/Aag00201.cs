using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag00201
    {
        public int AaAcctClassId { get; set; }
        public string AaAccountClass { get; set; }
        public string AaAcctClassDescr { get; set; }
        public string AaAcctClassDescr2 { get; set; }
        public byte AaSetCustId { get; set; }
        public byte AaSetVendId { get; set; }
        public byte AaSetItemId { get; set; }
        public byte AaSetSiteId { get; set; }
        public byte AaSetEmployeeId { get; set; }
        public byte AaSetAssetId { get; set; }
        public byte AaSetBookId { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
