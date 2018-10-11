using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Mc10001
    {
        public string Rvlueid { get; set; }
        public byte Revalunt { get; set; }
        public string Curncyid { get; set; }
        public string Ratetpid { get; set; }
        public short Rvludttn { get; set; }
        public string Exgtblid { get; set; }
        public short Rtclcmtd { get; set; }
        public DateTime Exchdate { get; set; }
        public decimal Xchgrate { get; set; }
        public int DexRowId { get; set; }
    }
}
