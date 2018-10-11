using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sy03100
    {
        public short Pyblgrbx { get; set; }
        public short Rcvbgrbx { get; set; }
        public string Cardname { get; set; }
        public byte Cbpayble { get; set; }
        public byte Cbrcvble { get; set; }
        public string Ckbknum1 { get; set; }
        public string Ckbknum2 { get; set; }
        public int Actindx { get; set; }
        public string Vendorid { get; set; }
        public decimal Noteindx { get; set; }
        public string Lstusred { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public int DexRowId { get; set; }
    }
}
