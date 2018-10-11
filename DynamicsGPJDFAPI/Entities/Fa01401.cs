using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Fa01401
    {
        public int Assetindex { get; set; }
        public int Purchlineseq { get; set; }
        public string Purchdesc { get; set; }
        public decimal AcquisitionCost { get; set; }
        public decimal OrigAcquisitionCost { get; set; }
        public string Vendorid { get; set; }
        public string Docnumbr { get; set; }
        public DateTime Docdate { get; set; }
        public string Trxsorce { get; set; }
        public string Orctrnum { get; set; }
        public int FaApPostIndex { get; set; }
        public string Pordnmbr { get; set; }
        public string Curncyid { get; set; }
        public short Currnidx { get; set; }
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public string Exgtblid { get; set; }
        public string Ratetpid { get; set; }
        public short Rtclcmtd { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; }
        public int DexRowId { get; set; }
    }
}
