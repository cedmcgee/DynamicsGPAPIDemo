using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Fa40201
    {
        public int Assetclassindx { get; set; }
        public string Assetclassid { get; set; }
        public string Assetclassiddesc { get; set; }
        public int Defacctgrpindx { get; set; }
        public int Definsclassindx { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; }
        public byte ClassNextAssetIdflg { get; set; }
        public string Nxtassetid { get; set; }
        public int DexRowId { get; set; }
    }
}
