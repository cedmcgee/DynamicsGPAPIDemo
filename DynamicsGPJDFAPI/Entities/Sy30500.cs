using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sy30500
    {
        public string Bchsourc { get; set; }
        public string Bachnumb { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Time1 { get; set; }
        public DateTime Glpostdt { get; set; }
        public short Series { get; set; }
        public int Numoftrx { get; set; }
        public decimal Rctrxseq { get; set; }
        public string Bchcomnt { get; set; }
        public byte Rvrsbach { get; set; }
        public string Userid { get; set; }
        public string Chekbkid { get; set; }
        public decimal Bchtotal { get; set; }
        public DateTime Bachdate { get; set; }
        public DateTime Modifdt { get; set; }
        public string Curncyid { get; set; }
        public int Cntrltrx { get; set; }
        public decimal Cntrltot { get; set; }
        public byte Approvl { get; set; }
        public DateTime Apprvldt { get; set; }
        public string Aprvluserid { get; set; }
        public short Origin { get; set; }
        public string Trxsorce { get; set; }
        public short WorkflowStatus { get; set; }
        public string Cardname { get; set; }
        public int DexRowId { get; set; }
    }
}
