using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Iv00103
    {
        public string Itemnmbr { get; set; }
        public string Vendorid { get; set; }
        public short Itmvndty { get; set; }
        public string Vnditnum { get; set; }
        public decimal Qtyrqstn { get; set; }
        public decimal Qtyonord { get; set; }
        public decimal QtyDropShipped { get; set; }
        public DateTime Lstorddt { get; set; }
        public decimal Lsordqty { get; set; }
        public decimal Lrcptqty { get; set; }
        public DateTime Lsrcptdt { get; set; }
        public decimal Lrcptcst { get; set; }
        public int Avrgldtm { get; set; }
        public short Norctitm { get; set; }
        public decimal Minorqty { get; set; }
        public decimal Maxordqty { get; set; }
        public decimal Ecordqty { get; set; }
        public string Vnditdsc { get; set; }
        public decimal LastOriginatingCost { get; set; }
        public string LastCurrencyId { get; set; }
        public short Freeonboard { get; set; }
        public string Prchsuom { get; set; }
        public short Currnidx { get; set; }
        public short Planningleadtime { get; set; }
        public decimal Ordermultiple { get; set; }
        public string Mnfctritmnmbr { get; set; }
        public int DexRowId { get; set; }
    }
}
