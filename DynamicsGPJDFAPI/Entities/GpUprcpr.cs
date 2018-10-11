using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class GpUprcpr
    {
        public int Comptrnm { get; set; }
        public string Jobnumbr { get; set; }
        public DateTime Trxenddt { get; set; }
        public string Employid { get; set; }
        public int Hourswkd { get; set; }
        public decimal Hrlypyrt { get; set; }
        public int Pyadnmbr { get; set; }
        public string Auctrlcd { get; set; }
        public decimal Totalpay { get; set; }
        public string Deprtmnt { get; set; }
        public string Jobtitle { get; set; }
        public string Payrcord { get; set; }
        public short Brkfld1 { get; set; }
        public int DexRowId { get; set; }
    }
}
