using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc30250
    {
        public short Srvrectype { get; set; }
        public string Callnbr { get; set; }
        public int Eqpline { get; set; }
        public string Linitmtyp { get; set; }
        public int Lnitmseq { get; set; }
        public short Qtytype { get; set; }
        public string Serltnum { get; set; }
        public decimal Serltqty { get; set; }
        public int Sltsqnum { get; set; }
        public DateTime Daterecd { get; set; }
        public decimal Dtseqnum { get; set; }
        public decimal Unitcost { get; set; }
        public string Itemnmbr { get; set; }
        public string Trxsorce { get; set; }
        public byte Posted { get; set; }
        public short Ovrserlt { get; set; }
        public int Equipid { get; set; }
        public string Bin { get; set; }
        public DateTime Mfgdate { get; set; }
        public DateTime Expndate { get; set; }
        public int Cmpntseq { get; set; }
        public int DexRowId { get; set; }
    }
}
