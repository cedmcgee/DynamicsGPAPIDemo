using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Rm00105
    {
        public string Cprcstnm { get; set; }
        public byte Naallowreceipts { get; set; }
        public byte Nacreditcheck { get; set; }
        public byte Nafinancecharge { get; set; }
        public byte Naholdinactive { get; set; }
        public byte Nadefparentven { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public int DexRowId { get; set; }

        public Rm00101 CprcstnmNavigation { get; set; }
    }
}
