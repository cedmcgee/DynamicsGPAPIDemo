using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Rm30202
    {
        public string Custnmbr { get; set; }
        public string Aptodcnm { get; set; }
        public short Aptodcty { get; set; }
        public decimal Apptoamt { get; set; }
        public string Apfrdcnm { get; set; }
        public short Apfrdcty { get; set; }
        public DateTime Apfrdcdt { get; set; }
        public string Trxsorce { get; set; }
        public decimal Distknam { get; set; }
        public decimal Wrofamnt { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime Glpostdt { get; set; }
        public byte Posted { get; set; }
        public decimal Gstdsamt { get; set; }
        public decimal Ppsamded { get; set; }
        public string Taxdtlid { get; set; }
        public decimal Oraptoam { get; set; }
        public decimal Ordistkn { get; set; }
        public decimal Ordatkn { get; set; }
        public decimal Orwrofam { get; set; }
        public decimal Rlganlos { get; set; }
        public int DexRowId { get; set; }
    }
}
