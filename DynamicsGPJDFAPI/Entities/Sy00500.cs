using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sy00500
    {
        public DateTime Glpostdt { get; set; }
        public string Bchsourc { get; set; }
        public string Bachnumb { get; set; }
        public short Series { get; set; }
        public byte Mkdtopst { get; set; }
        public int Numoftrx { get; set; }
        public short Recpstgs { get; set; }
        public byte Delbach { get; set; }
        public short Mscbdinc { get; set; }
        public short Bachfreq { get; set; }
        public DateTime Rclpstdt { get; set; }
        public short Nofpstgs { get; set; }
        public string Bchcomnt { get; set; }
        public byte Brkdnall { get; set; }
        public byte Chksprtd { get; set; }
        public byte Rvrsbach { get; set; }
        public string Userid { get; set; }
        public string Chekbkid { get; set; }
        public decimal Bchtotal { get; set; }
        public byte[] Bchemsg1 { get; set; }
        public byte[] Bchemsg2 { get; set; }
        public DateTime Bachdate { get; set; }
        public string Bchstrg1 { get; set; }
        public string Bchstrg2 { get; set; }
        public byte Posttogl { get; set; }
        public DateTime Modifdt { get; set; }
        public DateTime Creatddt { get; set; }
        public decimal Noteindx { get; set; }
        public string Curncyid { get; set; }
        public short Bchsttus { get; set; }
        public int Cntrltrx { get; set; }
        public decimal Cntrltot { get; set; }
        public short Petrxcnt { get; set; }
        public byte Approvl { get; set; }
        public DateTime Apprvldt { get; set; }
        public string Aprvluserid { get; set; }
        public short Origin { get; set; }
        public int Errstate { get; set; }
        public byte[] Glbchval { get; set; }
        public DateTime ComputerCheckDocDate { get; set; }
        public short SortChecksBy { get; set; }
        public byte Seprmtnc { get; set; }
        public short Reprnted { get; set; }
        public short Chkfrmts { get; set; }
        public string Trxsorce { get; set; }
        public short PmtMethod { get; set; }
        public short EftfileFormat { get; set; }
        public short WorkflowApprovalStatus { get; set; }
        public short WorkflowPriority { get; set; }
        public short WorkflowStatus { get; set; }
        public DateTime Time1 { get; set; }
        public byte ClearRecAmts { get; set; }
        public byte PurchasingPrepaymentBch { get; set; }
        public string Cardname { get; set; }
        public int DexRowId { get; set; }
    }
}
