using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Gl50503
    {
        public DateTime Trxdate { get; set; }
        public int Jrnentry { get; set; }
        public string Ortrxsrc { get; set; }
        public string Orctrnum { get; set; }
        public int Actindx { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Acctamnt { get; set; }
        public int DexRowId { get; set; }
    }
}
