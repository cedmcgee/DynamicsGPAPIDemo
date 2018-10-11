using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Mc00500
    {
        public string Bchsourc { get; set; }
        public string Bachnumb { get; set; }
        public short Series { get; set; }
        public string Curncyid { get; set; }
        public short Currnidx { get; set; }
        public decimal Origcntrltot { get; set; }
        public decimal Origbtchtot { get; set; }
        public string Exgtblid { get; set; }
        public decimal Xchgrate { get; set; }
        public string Ratetpid { get; set; }
        public short Rtclcmtd { get; set; }
        public DateTime Time1 { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Chekdate { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public int DexRowId { get; set; }
    }
}
