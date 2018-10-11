using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag20000
    {
        public int AaSubLedgerHdrId { get; set; }
        public short Series { get; set; }
        public short Doctype { get; set; }
        public string Docnumbr { get; set; }
        public string MasterId { get; set; }
        public short Pyrntype { get; set; }
        public byte[] AaHdrErrors { get; set; }
        public int DexRowId { get; set; }
    }
}
