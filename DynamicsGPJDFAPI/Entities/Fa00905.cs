using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Fa00905
    {
        public string Glintbtchnum { get; set; }
        public DateTime Glinttrxdate { get; set; }
        public int Financialindx { get; set; }
        public int Actindx { get; set; }
        public int Assetindex { get; set; }
        public short Fayear { get; set; }
        public short Faperiod { get; set; }
        public DateTime Deprfromdate { get; set; }
        public DateTime Deprtodate { get; set; }
        public string Sourcdoc { get; set; }
        public decimal Amount { get; set; }
        public int Bookindx { get; set; }
        public short LedgerId { get; set; }
        public short Transaccttype { get; set; }
        public string Refrence { get; set; }
        public string FaDocNumber { get; set; }
        public int DexRowId { get; set; }
    }
}
