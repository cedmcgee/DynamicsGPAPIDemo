using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc03000
    {
        public short SvcMasterDocumentType { get; set; }
        public string SvcMasterDocumentNumb { get; set; }
        public short SvcSourceDocumentId { get; set; }
        public short SvcSourceDocType { get; set; }
        public string Srcdocnum { get; set; }
        public short SvcDocumentId { get; set; }
        public string SvcModule { get; set; }
        public string Docnumbr { get; set; }
        public int Lnitmseq { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Createtime { get; set; }
        public string Crusrid { get; set; }
        public DateTime Modifdt { get; set; }
        public DateTime SvcModifiedTime { get; set; }
        public string Mdfusrid { get; set; }
        public string Dscriptn { get; set; }
        public int DexRowId { get; set; }
    }
}
