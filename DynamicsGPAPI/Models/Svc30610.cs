using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc30610
    {
        public short Consts { get; set; }
        public string Contnbr { get; set; }
        public decimal Lnseqnbr { get; set; }
        public int Equipid { get; set; }
        public byte Active { get; set; }
        public string Schedid { get; set; }
        public short SvcContractVersion { get; set; }
        public int DexRowId { get; set; }
    }
}
