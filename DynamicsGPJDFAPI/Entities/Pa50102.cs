using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pa50102
    {
        public string Userid { get; set; }
        public string Custnmbr { get; set; }
        public string Cprcstnm { get; set; }
        public short Apfrdcty { get; set; }
        public string Apfrdcnm { get; set; }
        public short Aptodcty { get; set; }
        public string Aptodcnm { get; set; }
        public decimal Apptoamt { get; set; }
        public decimal Oraptoam { get; set; }
        public decimal Distknam { get; set; }
        public decimal Ordistkn { get; set; }
        public string Fromcurr { get; set; }
        public short PaRefundApply { get; set; }
        public int DexRowId { get; set; }
    }
}
