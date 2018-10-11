using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pm00400
    {
        public string Cntrlnum { get; set; }
        public short Cntrltyp { get; set; }
        public short Dcstatus { get; set; }
        public short Doctype { get; set; }
        public string Vendorid { get; set; }
        public string Docnumbr { get; set; }
        public string Trxsorce { get; set; }
        public string Chekbkid { get; set; }
        public DateTime Duedate { get; set; }
        public DateTime Discdate { get; set; }
        public string Bchsourc { get; set; }
        public DateTime Docdate { get; set; }
        public string Userid { get; set; }
        public int DexRowId { get; set; }
    }
}
