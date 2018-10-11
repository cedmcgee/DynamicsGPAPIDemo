using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pm80950
    {
        public string Bachnumb { get; set; }
        public string Bchsourc { get; set; }
        public string Pmntnmbr { get; set; }
        public int Seqnumbr { get; set; }
        public DateTime Docdate { get; set; }
        public string Docnumbr { get; set; }
        public string Vendorid { get; set; }
        public string Vendname { get; set; }
        public string Vndchknm { get; set; }
        public string Curncyid { get; set; }
        public byte Voided { get; set; }
        public short Doctype { get; set; }
        public string Chkcomnt { get; set; }
        public string Userid { get; set; }
        public byte Seprmtnc { get; set; }
        public short Error { get; set; }
        public short EmailType { get; set; }
        public decimal Docamnt { get; set; }
        public short Pymttype { get; set; }
        public byte Electronic { get; set; }
        public int DexRowId { get; set; }
    }
}
