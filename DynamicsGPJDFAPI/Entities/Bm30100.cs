using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Bm30100
    {
        public string Trxsorce { get; set; }
        public string Bachnumb { get; set; }
        public string Bchsourc { get; set; }
        public string Bchcomnt { get; set; }
        public short Bachfreq { get; set; }
        public DateTime Pstgdate { get; set; }
        public int Numoftrx { get; set; }
        public decimal Bchtotal { get; set; }
        public decimal Noteindx { get; set; }
        public short Origin { get; set; }
        public byte Approvl { get; set; }
        public string Aprvluserid { get; set; }
        public DateTime Apprvldt { get; set; }
        public int Cntrltrx { get; set; }
        public decimal Cntrltot { get; set; }
        public int DexRowId { get; set; }
    }
}
