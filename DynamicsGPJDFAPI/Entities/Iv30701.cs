using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Iv30701
    {
        public string Stckcntid { get; set; }
        public int Seqnumbr { get; set; }
        public string Itemnmbr { get; set; }
        public string Locncode { get; set; }
        public string Binnmbr { get; set; }
        public string Baseuofm { get; set; }
        public decimal Countedqty { get; set; }
        public decimal Capturedqty { get; set; }
        public DateTime Cptrdt { get; set; }
        public DateTime Cptrtm { get; set; }
        public short Itmtrkop { get; set; }
        public string Ivdocnbr { get; set; }
        public short Ivdoctyp { get; set; }
        public decimal Unitcost { get; set; }
        public decimal Varianceqty { get; set; }
        public short Decplqty { get; set; }
        public short Decplcur { get; set; }
        public string ReasonCode { get; set; }
        public int DexRowId { get; set; }
    }
}
