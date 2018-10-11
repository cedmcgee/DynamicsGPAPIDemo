using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sop60100
    {
        public string Sopnumbe { get; set; }
        public short Soptype { get; set; }
        public int Lnitmseq { get; set; }
        public int Cmpntseq { get; set; }
        public string Ponumber { get; set; }
        public int Ord { get; set; }
        public byte[] Rctinvcerrors { get; set; }
        public decimal Rcptcost { get; set; }
        public short Rcptpriority { get; set; }
        public decimal Qtyonpo { get; set; }
        public decimal Qtyonpobase { get; set; }
        public decimal Qtyrecvd { get; set; }
        public decimal Qtyrecinbase { get; set; }
        public DateTime Rqstffdate { get; set; }
        public decimal Qtybsuom { get; set; }
        public string Locncode { get; set; }
        public string Itemdesc { get; set; }
        public DateTime Docdate { get; set; }
        public string Uofm { get; set; }
        public int DexRowId { get; set; }
    }
}
