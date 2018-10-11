using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag04000
    {
        public int AaFasetupId { get; set; }
        public short ListId { get; set; }
        public string Interid { get; set; }
        public string Userid { get; set; }
        public short Series { get; set; }
        public int Actindx { get; set; }
        public short Accttype { get; set; }
        public short AaBrowseType { get; set; }
        public int AaAssetIndex { get; set; }
        public int AaBookIndex { get; set; }
        public int AaAliasId { get; set; }
        public int DexRowId { get; set; }
    }
}
