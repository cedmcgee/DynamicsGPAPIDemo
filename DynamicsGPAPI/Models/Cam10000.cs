using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Cam10000
    {
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public string Vchrnmbr { get; set; }
        public short Doctype { get; set; }
        public short Cntrltyp { get; set; }
        public string Vendorid { get; set; }
        public decimal CamAmountTotal { get; set; }
        public decimal CamAmountOwing { get; set; }
        public int DexRowId { get; set; }
    }
}
