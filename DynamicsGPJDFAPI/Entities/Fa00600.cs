using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Fa00600
    {
        public int Assetindex { get; set; }
        public int Insclassindx { get; set; }
        public short Insuranceyear { get; set; }
        public decimal Insurancevalue { get; set; }
        public decimal Replacementcost { get; set; }
        public decimal Reprocost { get; set; }
        public decimal Deprreprocost { get; set; }
        public decimal Exclusionamt { get; set; }
        public string Exclusiontype { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; }
        public int DexRowId { get; set; }
    }
}
