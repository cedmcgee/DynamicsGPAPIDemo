using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Cm20502
    {
        public string Audittrail { get; set; }
        public decimal Cmrecnum { get; set; }
        public decimal Reconum { get; set; }
        public string CmtrxNum { get; set; }
        public short CmtrxType { get; set; }
        public string CmlinkId { get; set; }
        public DateTime Trxdate { get; set; }
        public decimal Trxamnt { get; set; }
        public DateTime Clearedate { get; set; }
        public decimal ClrdAmt { get; set; }
        public string Curncyid { get; set; }
        public string Paidtorcvdfrom { get; set; }
        public string Dscriptn { get; set; }
        public short Deptype { get; set; }
        public string Sourcdoc { get; set; }
        public short Srcdoctyp { get; set; }
        public string Srcdocnum { get; set; }
        public string Userid { get; set; }
        public string Chekbkid { get; set; }
        public int DexRowId { get; set; }
    }
}
