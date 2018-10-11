using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class PalbCash
    {
        public string Bachnumb { get; set; }
        public string Bchsourc { get; set; }
        public short Rmdtypal { get; set; }
        public string Docnumbr { get; set; }
        public string Custnmbr { get; set; }
        public string Custname { get; set; }
        public string Bnkbrnch { get; set; }
        public string Bankname { get; set; }
        public string Bnkactnm { get; set; }
        public string LockboxId { get; set; }
        public int Errstate { get; set; }
        public int DexRowId { get; set; }
    }
}
