using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Dd30100
    {
        public int Indxlong { get; set; }
        public byte Ddautost { get; set; }
        public byte Inclpymt { get; set; }
        public byte Printed { get; set; }
        public string Bldchdid { get; set; }
        public DateTime Bldchkdt { get; set; }
        public DateTime Bldchtim { get; set; }
        public string Auctrlcd { get; set; }
        public string Userid { get; set; }
        public DateTime Paydate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public int DexRowId { get; set; }
    }
}
