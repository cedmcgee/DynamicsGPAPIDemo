using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pm81000
    {
        public string Userid { get; set; }
        public DateTime Time1 { get; set; }
        public string Cmpnynam { get; set; }
        public short ChangeStatus { get; set; }
        public int Seqnumbr { get; set; }
        public int Actindx { get; set; }
        public byte DefaultOnTrx { get; set; }
        public int StoredAccountIndex { get; set; }
        public byte StoredDefaultOnTrx { get; set; }
        public int DexRowId { get; set; }
    }
}
