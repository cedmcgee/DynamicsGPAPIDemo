using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class PaActvty
    {
        public string LockboxId { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public string Userid { get; set; }
        public string Bachnumb { get; set; }
        public decimal Bchtotal { get; set; }
        public int Numoftrx { get; set; }
        public int NoOfTrxRejected { get; set; }
        public string Strng132 { get; set; }
        public int DexRowId { get; set; }
    }
}
