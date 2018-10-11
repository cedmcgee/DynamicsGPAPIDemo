using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00951
    {
        public string Uomschdl { get; set; }
        public string Itemnmbr { get; set; }
        public byte Metered { get; set; }
        public byte Rtrnable { get; set; }
        public string Prdline { get; set; }
        public string Warrcde { get; set; }
        public decimal Mtbf { get; set; }
        public decimal Mtbi { get; set; }
        public decimal Mttr { get; set; }
        public decimal Retcost { get; set; }
        public byte SvcPmAllowed { get; set; }
        public byte SvcContractible { get; set; }
        public string Slrwarr { get; set; }
        public string Vendorid { get; set; }
        public byte SvcUseCurrentCost { get; set; }
        public int DexRowId { get; set; }
    }
}
