using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Fa00904
    {
        public int Financialindx { get; set; }
        public int Assetindex { get; set; }
        public int Bookindx { get; set; }
        public string FaDocNumber { get; set; }
        public DateTime Transdatestamp { get; set; }
        public DateTime Transtimestamp { get; set; }
        public short Fiscalyradded { get; set; }
        public short Fayear { get; set; }
        public short Faperiod { get; set; }
        public DateTime Deprfromdate { get; set; }
        public DateTime Deprtodate { get; set; }
        public decimal Amount { get; set; }
        public string Transuserid { get; set; }
        public string Sourcdoc { get; set; }
        public short Transaccttype { get; set; }
        public byte Interfacegl { get; set; }
        public DateTime Glinttrxdate { get; set; }
        public DateTime Glintdatestamp { get; set; }
        public DateTime Glinttimestamp { get; set; }
        public int Glintacctindx { get; set; }
        public string Glintbtchnum { get; set; }
        public int FaResetOffsetIndex { get; set; }
        public string FaResetUserId { get; set; }
        public DateTime FaResetDate { get; set; }
        public DateTime FaResetTime { get; set; }
        public short LedgerId { get; set; }
        public string Refrence { get; set; }
        public int DexRowId { get; set; }
    }
}
