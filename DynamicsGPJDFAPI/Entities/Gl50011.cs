using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Gl50011
    {
        public string Yearid { get; set; }
        public short Periodid { get; set; }
        public short Amntfrom { get; set; }
        public int Actindx { get; set; }
        public decimal Dollar1 { get; set; }
        public int Sqlsesid { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public int DexRowId { get; set; }
    }
}
