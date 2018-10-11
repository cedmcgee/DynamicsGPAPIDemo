using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Dta10200
    {
        public short Dtaseries { get; set; }
        public string Dtaref { get; set; }
        public int Actindx { get; set; }
        public int Seqnumbr { get; set; }
        public string Groupid { get; set; }
        public string Codeid { get; set; }
        public string Docnumbr { get; set; }
        public short Rmdtypal { get; set; }
        public string Postdesc { get; set; }
        public decimal Dtaqnty { get; set; }
        public decimal Codeamt { get; set; }
        public DateTime Trxdate { get; set; }
        public int DexRowId { get; set; }
    }
}
