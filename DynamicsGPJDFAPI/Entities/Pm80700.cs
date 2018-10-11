using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pm80700
    {
        public string Vendorid { get; set; }
        public string Vchrnmbr { get; set; }
        public string Bachnumb { get; set; }
        public string Taxdtlid { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Ortaxamt { get; set; }
        public int Actindx { get; set; }
        public string Trxsorce { get; set; }
        public string Curncyid { get; set; }
        public short Currnidx { get; set; }
        public int DexRowId { get; set; }
    }
}
