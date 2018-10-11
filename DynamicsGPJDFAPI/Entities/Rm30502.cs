using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Rm30502
    {
        public decimal Noteindx { get; set; }
        public DateTime Glpostdt { get; set; }
        public string Trxsorce { get; set; }
        public string Bchsourc { get; set; }
        public string Bachnumb { get; set; }
        public byte Reprntnt { get; set; }
        public byte Trxmisng { get; set; }
        public string Chekbkid { get; set; }
        public int Numoftrx { get; set; }
        public short Bachfreq { get; set; }
        public string Bchcomnt { get; set; }
        public string Userid { get; set; }
        public byte Approvl { get; set; }
        public DateTime Apprvldt { get; set; }
        public string Aprvluserid { get; set; }
        public decimal Cntrltot { get; set; }
        public int Cntrltrx { get; set; }
        public decimal Bchtotal { get; set; }
        public short WorkflowApprovalStatus { get; set; }
        public short WorkflowPriority { get; set; }
        public short WorkflowStatus { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Time1 { get; set; }
        public int DexRowId { get; set; }
    }
}
