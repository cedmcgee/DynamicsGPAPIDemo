using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Iv41100
    {
        public string LandedCostId { get; set; }
        public string LongDescription { get; set; }
        public decimal Noteindx { get; set; }
        public string Vendorid { get; set; }
        public string Curncyid { get; set; }
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; }
        public short Decplcur { get; set; }
        public short Odecplcu { get; set; }
        public int Acpuridx { get; set; }
        public int Purpvidx { get; set; }
        public byte InvoiceMatch { get; set; }
        public short Calcmthd { get; set; }
        public decimal OrigLandedCostAmount { get; set; }
        public int CalculationPercentage { get; set; }
        public byte RevalueInventory { get; set; }
        public int TolerancePercentage { get; set; }
        public decimal VendorNoteIndex { get; set; }
        public decimal CurrencyNoteIndex { get; set; }
        public int DexRowId { get; set; }
    }
}
