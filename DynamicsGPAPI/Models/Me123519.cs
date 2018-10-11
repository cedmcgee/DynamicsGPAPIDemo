using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Me123519
    {
        public string OutputFormat { get; set; }
        public short MeTransactionType { get; set; }
        public string MeTrxMatchingCode { get; set; }
        public byte MeVoidTrxAmountsZero { get; set; }
        public byte MeOmitChecksWAlphas { get; set; }
        public int DexRowId { get; set; }
    }
}
