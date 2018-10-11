using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc35255
    {
        public short ReturnRecordType { get; set; }
        public string Retdocid { get; set; }
        public decimal Lnseqnbr { get; set; }
        public short Qtytype { get; set; }
        public decimal Serltqty { get; set; }
        public string ReturnItemNumber { get; set; }
        public string ReturnSerialNumber { get; set; }
        public int ReturnEquipmentId { get; set; }
        public int Sltsqnum { get; set; }
        public string Bin { get; set; }
        public decimal Retcost { get; set; }
        public byte SvcOriginalSerial { get; set; }
        public DateTime Daterecd { get; set; }
        public decimal Dtseqnum { get; set; }
        public string Trxsorce { get; set; }
        public byte Marked { get; set; }
        public byte Posted { get; set; }
        public DateTime Mfgdate { get; set; }
        public DateTime Expndate { get; set; }
        public int Cmpntseq { get; set; }
        public int DexRowId { get; set; }
    }
}
