using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sy00300
    {
        public short Sgmtnumb { get; set; }
        public string Sgmtname { get; set; }
        public short Lofsgmnt { get; set; }
        public short Mxlenseg { get; set; }
        public short Usdfsgky { get; set; }
        public byte Mnsegind { get; set; }
        public string SegmentWidth { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
