using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00120
    {
        public short SvcDocumentType { get; set; }
        public short Rcrdtype { get; set; }
        public string Docid { get; set; }
        public int Eqpline { get; set; }
        public int Lnitmseq { get; set; }
        public string Techid { get; set; }
        public string WorkType { get; set; }
        public string Stationid { get; set; }
        public string Employid { get; set; }
        public string PayCode { get; set; }
        public string Deprtmnt { get; set; }
        public string Jobtitle { get; set; }
        public string Statecd { get; set; }
        public string Localtax { get; set; }
        public string Sutastat { get; set; }
        public string Wrkrcomp { get; set; }
        public string Shftcode { get; set; }
        public int Trxhrunt { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Strttime { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Endtime { get; set; }
        public byte Posted { get; set; }
        public int DexRowId { get; set; }
    }
}
