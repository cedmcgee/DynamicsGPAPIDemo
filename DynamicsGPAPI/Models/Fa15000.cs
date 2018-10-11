using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Fa15000
    {
        public string Glintbtchnum { get; set; }
        public byte Posted { get; set; }
        public DateTime Glinttrxdate { get; set; }
        public string GlInterfaceComment { get; set; }
        public short GlIntfBeginPeriod { get; set; }
        public short GlInterfaceBeginYear { get; set; }
        public short GlInterfaceEndPeriod { get; set; }
        public short GlInterfaceEndYear { get; set; }
        public string Ssrcedoc { get; set; }
        public string Endsrcdc { get; set; }
        public string StartAssetId { get; set; }
        public string EndAssetId { get; set; }
        public short StartAssetIdSuffix { get; set; }
        public short EndAssetIdSuffix { get; set; }
        public string Sttclsid { get; set; }
        public string Endclsid { get; set; }
        public int Bookindx { get; set; }
        public int Jrnentry { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public string Userid { get; set; }
        public int DexRowId { get; set; }
    }
}
