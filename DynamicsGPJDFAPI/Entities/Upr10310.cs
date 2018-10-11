using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Upr10310
    {
        public short Mlchktyp { get; set; }
        public int Pyadnmbr { get; set; }
        public int Mltrxnbr { get; set; }
        public int Seqnumbr { get; set; }
        public int Actindx { get; set; }
        public short Upractyp { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public string Deprtmnt { get; set; }
        public string Jobtitle { get; set; }
        public string Uprtrxcd { get; set; }
        public int DexRowId { get; set; }
    }
}
