using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc35256
    {
        public short ReturnRecordType { get; set; }
        public string Retdocid { get; set; }
        public decimal Lnseqnbr { get; set; }
        public short Qtytype { get; set; }
        public decimal Serltqty { get; set; }
        public int Sltsqnum { get; set; }
        public string ReplaceItemNumber { get; set; }
        public string ReplaceSerialNumber { get; set; }
        public int ReplaceEquipmentId { get; set; }
        public string Bin { get; set; }
        public decimal ReplaceCost { get; set; }
        public DateTime Mfgdate { get; set; }
        public DateTime Expndate { get; set; }
        public DateTime Daterecd { get; set; }
        public decimal Dtseqnum { get; set; }
        public int Cmpntseq { get; set; }
        public int DexRowId { get; set; }
    }
}
