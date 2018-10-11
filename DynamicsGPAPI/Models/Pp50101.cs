using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pp50101
    {
        public string Userid { get; set; }
        public string Bchsourc { get; set; }
        public string Bachnumb { get; set; }
        public int Jrnentry { get; set; }
        public decimal Sqncline { get; set; }
        public int Actindx { get; set; }
        public int Offindx { get; set; }
        public decimal Trxamnt { get; set; }
        public byte[] Gllinmsg { get; set; }
        public byte[] Gllinms2 { get; set; }
        public DateTime Trxdate { get; set; }
        public short Accttype { get; set; }
        public string Dscriptn { get; set; }
        public string Curncyid { get; set; }
        public short Currnidx { get; set; }
        public short Funcridx { get; set; }
        public decimal Origamt { get; set; }
        public string Docnumbr { get; set; }
        public string Custnmbr { get; set; }
        public string Custname { get; set; }
        public DateTime Docdate { get; set; }
        public int DexRowId { get; set; }
    }
}
