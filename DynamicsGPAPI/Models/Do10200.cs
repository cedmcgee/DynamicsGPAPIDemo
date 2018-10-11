using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Do10200
    {
        public short Rmdtypal { get; set; }
        public string Docnumbr { get; set; }
        public DateTime Expndate { get; set; }
        public string DoAuthcode { get; set; }
        public byte Processelectronically { get; set; }
        public int NextElectronicNumber { get; set; }
        public int DexRowId { get; set; }
    }
}
