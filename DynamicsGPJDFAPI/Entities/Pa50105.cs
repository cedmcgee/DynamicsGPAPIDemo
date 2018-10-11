using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pa50105
    {
        public string Userid { get; set; }
        public short Doctype { get; set; }
        public string Docnumbr { get; set; }
        public string Vchrnmbr { get; set; }
        public short Moduleid { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime Duedate { get; set; }
        public string CustVenId { get; set; }
        public decimal Curtrxam { get; set; }
        public decimal Orctrxam { get; set; }
        public string Curncyid { get; set; }
        public short Voidstts { get; set; }
        public decimal Appldamt { get; set; }
        public decimal Orappamt { get; set; }
        public decimal Distknam { get; set; }
        public decimal Ordistkn { get; set; }
        public decimal Disavtkn { get; set; }
        public decimal Ordatkn { get; set; }
        public string Taxdtlid { get; set; }
        public decimal Gstdsamt { get; set; }
        public decimal Ppsamded { get; set; }
        public int DexRowId { get; set; }
    }
}
