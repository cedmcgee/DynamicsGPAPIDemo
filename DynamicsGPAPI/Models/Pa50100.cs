using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pa50100
    {
        public string Userid { get; set; }
        public string Custnmbr { get; set; }
        public string Cprcstnm { get; set; }
        public string Vendorid { get; set; }
        public decimal Balance { get; set; }
        public decimal OriginatingBalance { get; set; }
        public int Numofinv { get; set; }
        public string Docnumbr { get; set; }
        public string Vchrnmbr { get; set; }
        public string Curncyid { get; set; }
        public short Error { get; set; }
        public int DexRowId { get; set; }
    }
}
