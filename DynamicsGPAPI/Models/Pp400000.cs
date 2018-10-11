using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pp400000
    {
        public string Bchsourc { get; set; }
        public short Series { get; set; }
        public string Bachnumb { get; set; }
        public string Bchcomnt { get; set; }
        public short Bchsttus { get; set; }
        public byte Mkdtopst { get; set; }
        public int Numoftrx { get; set; }
        public decimal Bchtotal { get; set; }
        public int Cntrltrx { get; set; }
        public decimal Cntrltot { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public string Userid { get; set; }
        public byte[] Bchemsg1 { get; set; }
        public byte[] Bchemsg2 { get; set; }
        public string Trxsorce { get; set; }
        public int DexRowId { get; set; }
    }
}
