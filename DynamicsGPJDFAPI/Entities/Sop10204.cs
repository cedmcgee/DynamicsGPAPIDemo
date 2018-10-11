using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sop10204
    {
        public string Sopnumbe { get; set; }
        public short Soptype { get; set; }
        public int Cmpntseq { get; set; }
        public int Lnitmseq { get; set; }
        public string Itemnmbr { get; set; }
        public short Promosts { get; set; }
        public short Promotyp { get; set; }
        public decimal Psitmval { get; set; }
        public string Freeitem { get; set; }
        public string Freeuofm { get; set; }
        public int Prmcmseq { get; set; }
        public int Prmliseq { get; set; }
        public int DexRowId { get; set; }
    }
}
