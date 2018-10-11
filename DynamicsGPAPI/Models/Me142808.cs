using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Me142808
    {
        public string Mebankid { get; set; }
        public short MeTransactionType { get; set; }
        public string MeTransactionCode { get; set; }
        public short Doctype { get; set; }
        public int Actindx { get; set; }
        public string DistRef { get; set; }
        public string TrxCodeDesc { get; set; }
        public int DexRowId { get; set; }
    }
}
