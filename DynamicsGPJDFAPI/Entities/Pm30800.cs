using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pm30800
    {
        public string Vendorid { get; set; }
        public string Vchrnmbr { get; set; }
        public short Doctype { get; set; }
        public string Docnumbr { get; set; }
        public string Poprctnm { get; set; }
        public DateTime TaxDate { get; set; }
        public byte TaxInvRecvd { get; set; }
        public decimal Gstdsamt { get; set; }
        public int DexRowId { get; set; }
    }
}
