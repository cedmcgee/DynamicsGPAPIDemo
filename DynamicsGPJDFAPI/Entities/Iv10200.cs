using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Iv10200
    {
        public string Itemnmbr { get; set; }
        public string Trxloctn { get; set; }
        public DateTime Daterecd { get; set; }
        public int Rctseqnm { get; set; }
        public byte Rcptsold { get; set; }
        public decimal Qtyrecvd { get; set; }
        public decimal Qtysold { get; set; }
        public decimal Qtycomtd { get; set; }
        public decimal Qtyreserved { get; set; }
        public DateTime Flrplndt { get; set; }
        public short Pchsrcty { get; set; }
        public string Rcptnmbr { get; set; }
        public string Vendorid { get; set; }
        public string Pordnmbr { get; set; }
        public decimal Unitcost { get; set; }
        public short Qtytype { get; set; }
        public byte LandedCost { get; set; }
        public byte Negqtysopinv { get; set; }
        public short Vctnmthd { get; set; }
        public decimal Adjunitcost { get; set; }
        public decimal Qtyonhnd { get; set; }
        public int DexRowId { get; set; }
    }
}
