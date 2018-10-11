using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Iv50200
    {
        public byte Includeitem { get; set; }
        public string Itemnmbr { get; set; }
        public string Locncode { get; set; }
        public string Binnmbr { get; set; }
        public string Itmclscd { get; set; }
        public short Abccode { get; set; }
        public string Itmgedsc { get; set; }
        public string Itemdesc { get; set; }
        public DateTime Lstcntdt { get; set; }
        public short Stckcntintrvl { get; set; }
        public DateTime Nxtcntdt { get; set; }
        public DateTime Nxtcnttm { get; set; }
        public byte Updated { get; set; }
        public short Itemtype { get; set; }
        public string Userid { get; set; }
        public short IntegerValue { get; set; }
        public int DexRowId { get; set; }
    }
}
