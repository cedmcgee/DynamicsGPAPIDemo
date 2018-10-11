using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sop50500
    {
        public string Userid { get; set; }
        public int Seqnumbr { get; set; }
        public string Prchldid { get; set; }
        public byte PasswordRequired { get; set; }
        public byte[] Password { get; set; }
        public byte[] Dumypswd { get; set; }
        public short PasswordValid { get; set; }
        public byte Mktoproc { get; set; }
        public int DexRowId { get; set; }
    }
}
