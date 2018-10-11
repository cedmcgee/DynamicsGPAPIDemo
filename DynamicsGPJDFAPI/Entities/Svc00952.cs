using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00952
    {
        public string Itemnmbr { get; set; }
        public string Locncode { get; set; }
        public byte GoodStock { get; set; }
        public string Trnsfloc { get; set; }
        public string Itlocn { get; set; }
        public short Etadays { get; set; }
        public string Shipmthd { get; set; }
        public short UsedOptions { get; set; }
        public byte SvcItemSiteDelta { get; set; }
        public byte SvcCreateNonSerialEq { get; set; }
        public int DexRowId { get; set; }
    }
}
