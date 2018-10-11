using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pa50103
    {
        public string Aptvchnm { get; set; }
        public string Vchrnmbr { get; set; }
        public string Vendorid { get; set; }
        public short Aptodcty { get; set; }
        public short Doctype { get; set; }
        public string Aptodcnm { get; set; }
        public decimal Appldamt { get; set; }
        public DateTime Docdate { get; set; }
        public string Custnmbr { get; set; }
        public string Curncyid { get; set; }
        public int DexRowId { get; set; }
    }
}
