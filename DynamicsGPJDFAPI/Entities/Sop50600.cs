using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sop50600
    {
        public string Userid { get; set; }
        public int Seqnumbr { get; set; }
        public string Docid { get; set; }
        public byte PasswordRequired { get; set; }
        public byte[] Password { get; set; }
        public byte[] Dumypswd { get; set; }
        public short PasswordValid { get; set; }
        public int DexRowId { get; set; }
    }
}
