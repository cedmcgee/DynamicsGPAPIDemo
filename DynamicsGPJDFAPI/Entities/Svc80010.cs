using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc80010
    {
        public string Serlnmbr { get; set; }
        public string Pmdtlid { get; set; }
        public string Schedid { get; set; }
        public string Callnbr { get; set; }
        public string Itemnmbr { get; set; }
        public string Srvtype { get; set; }
        public string Custnmbr { get; set; }
        public decimal Quantity { get; set; }
        public decimal Parstotprc { get; set; }
        public decimal Labstotprc { get; set; }
        public decimal Parstotcst { get; set; }
        public decimal Labstotcst { get; set; }
        public byte Marked { get; set; }
        public short Consts { get; set; }
        public string Contnbr { get; set; }
        public decimal Lnseqnbr { get; set; }
        public int DexRowId { get; set; }
    }
}
