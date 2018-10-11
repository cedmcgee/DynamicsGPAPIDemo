using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pm80100
    {
        public string Trxsorce { get; set; }
        public DateTime Posteddt { get; set; }
        public DateTime Glpostdt { get; set; }
        public string Bchsourc { get; set; }
        public string Bachnumb { get; set; }
        public string Chekbkid { get; set; }
        public int Numoftrx { get; set; }
        public short Recpstgs { get; set; }
        public short Mscbdinc { get; set; }
        public short Bachfreq { get; set; }
        public short Nofpstgs { get; set; }
        public string Bchcomnt { get; set; }
        public string Userid { get; set; }
        public decimal Noteindx { get; set; }
        public byte Rcdsrmvd { get; set; }
        public decimal Bchtotal { get; set; }
        public int Cntrltrx { get; set; }
        public decimal Cntrltot { get; set; }
        public byte Approvl { get; set; }
        public DateTime Apprvldt { get; set; }
        public string Aprvluserid { get; set; }
        public short WorkflowApprovalStatus { get; set; }
        public short WorkflowPriority { get; set; }
        public short WorkflowStatus { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Time1 { get; set; }
        public int DexRowId { get; set; }
    }
}
