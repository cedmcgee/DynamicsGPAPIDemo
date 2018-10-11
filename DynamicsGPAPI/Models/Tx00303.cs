using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Tx00303
    {
        public string TaxReturnId { get; set; }
        public int Actindx { get; set; }
        public string Sourcdoc { get; set; }
        public string Sdocdscr { get; set; }
        public int Jrnentry { get; set; }
        public DateTime Trxdate { get; set; }
        public string Ordocnum { get; set; }
        public DateTime Orpstddt { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public int DexRowId { get; set; }
    }
}
