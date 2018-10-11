using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sy03300
    {
        public string Pymtrmid { get; set; }
        public short Duetype { get; set; }
        public short Duedtds { get; set; }
        public short Disctype { get; set; }
        public short Discdtds { get; set; }
        public short Dsclctyp { get; set; }
        public decimal Dscdlram { get; set; }
        public short Dscpctam { get; set; }
        public byte Salpurch { get; set; }
        public byte Discntcb { get; set; }
        public byte Freight { get; set; }
        public byte Misc { get; set; }
        public byte Tax { get; set; }
        public decimal Noteindx { get; set; }
        public byte Cbuvatmd { get; set; }
        public string Lstusred { get; set; }
        public DateTime Modifdt { get; set; }
        public DateTime Creatddt { get; set; }
        public byte Usegrper { get; set; }
        public short CalculateDateFrom { get; set; }
        public short CalculateDateFromDays { get; set; }
        public short DueMonth { get; set; }
        public short DiscountMonth { get; set; }
        public int DexRowId { get; set; }
    }
}
