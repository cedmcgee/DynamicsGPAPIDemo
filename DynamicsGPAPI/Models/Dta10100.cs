using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Dta10100
    {
        public short Dtaseries { get; set; }
        public string Dtaref { get; set; }
        public int Actindx { get; set; }
        public int Seqnumbr { get; set; }
        public string Groupid { get; set; }
        public string DtaGlReference { get; set; }
        public string Docnumbr { get; set; }
        public short Rmdtypal { get; set; }
        public decimal Groupamt { get; set; }
        public int Jrnentry { get; set; }
        public DateTime Trxdate { get; set; }
        public short Pstgstus { get; set; }
        public int DexRowId { get; set; }
    }
}
