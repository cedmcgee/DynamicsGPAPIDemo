using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pop30200
    {
        public string PoprequisitionNumber { get; set; }
        public decimal RequisitionNoteIndex { get; set; }
        public string RequisitionDescription { get; set; }
        public short RequisitionStatus { get; set; }
        public string Commntid { get; set; }
        public decimal CommentNoteIndex { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime Reqdate { get; set; }
        public string Reqstdby { get; set; }
        public string Prstadcd { get; set; }
        public string Cmpnynam { get; set; }
        public string Contact { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Ccode { get; set; }
        public string Country { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Fax { get; set; }
        public decimal Docamnt { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public string User2ent { get; set; }
        public short Flags { get; set; }
        public byte Voided { get; set; }
        public short WorkflowStatus { get; set; }
        public string DomainUserName { get; set; }
        public string Userdef1 { get; set; }
        public string Userdef2 { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
