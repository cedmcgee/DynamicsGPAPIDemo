using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sy02200
    {
        public string Filexpnm { get; set; }
        public byte Prntjrnl { get; set; }
        public short Series { get; set; }
        public string Trxsourc { get; set; }
        public string Ptgrptnm { get; set; }
        public byte Asectmnt { get; set; }
        public byte Prtoprnt { get; set; }
        public byte Prtoscnt { get; set; }
        public byte Prtoflnt { get; set; }
        public short Expttype { get; set; }
        public short Apndrplc { get; set; }
        public int DexRowId { get; set; }
    }
}
