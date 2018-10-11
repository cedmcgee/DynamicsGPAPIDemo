using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sop50100
    {
        public short Procorig { get; set; }
        public string Userid { get; set; }
        public byte Mktoproc { get; set; }
        public string Sopnumbe { get; set; }
        public short Soptype { get; set; }
        public DateTime Docdate { get; set; }
        public string Custnmbr { get; set; }
        public string Custname { get; set; }
        public string Cstponbr { get; set; }
        public string Bachnumb { get; set; }
        public string Docid { get; set; }
        public short Error { get; set; }
        public int DexRowId { get; set; }
    }
}
