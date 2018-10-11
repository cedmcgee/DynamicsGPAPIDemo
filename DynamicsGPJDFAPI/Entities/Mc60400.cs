using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Mc60400
    {
        public string Denomcurr { get; set; }
        public byte Enabled { get; set; }
        public string Userid { get; set; }
        public int Realgain { get; set; }
        public int Realloss { get; set; }
        public DateTime Pstgdate { get; set; }
        public int DexRowId { get; set; }
    }
}
