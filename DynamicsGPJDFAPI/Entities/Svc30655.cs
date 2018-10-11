using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc30655
    {
        public short Consts { get; set; }
        public string Contnbr { get; set; }
        public decimal Lnseqnbr { get; set; }
        public string Opttype { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public decimal Unitprce { get; set; }
        public decimal Unitcost { get; set; }
        public decimal Oruntcst { get; set; }
        public decimal Oruntprc { get; set; }
        public short SvcContractVersion { get; set; }
        public int DexRowId { get; set; }
    }
}
