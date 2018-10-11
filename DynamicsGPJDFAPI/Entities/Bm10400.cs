using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Bm10400
    {
        public string TrxId { get; set; }
        public int ComponentId { get; set; }
        public short Sltype { get; set; }
        public int Sltsqnum { get; set; }
        public string Serltnum { get; set; }
        public decimal Serltqty { get; set; }
        public string Itemnmbr { get; set; }
        public short Qtytype { get; set; }
        public DateTime Daterecd { get; set; }
        public decimal Dtseqnum { get; set; }
        public short Ovrserlt { get; set; }
        public int Parslseqn { get; set; }
        public int ParentComponentId { get; set; }
        public short Itmtrkop { get; set; }
        public string Trxsorce { get; set; }
        public decimal Unitcost { get; set; }
        public short Status { get; set; }
        public string Locncode { get; set; }
        public string Bin { get; set; }
        public DateTime Mfgdate { get; set; }
        public DateTime Expndate { get; set; }
        public int DexRowId { get; set; }
    }
}
