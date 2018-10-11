using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00350
    {
        public int Equipid { get; set; }
        public DateTime SvcPmAnnualDate { get; set; }
        public string Schedid { get; set; }
        public string Pmdtlid { get; set; }
        public short Freqofpm { get; set; }
        public string Srvtype { get; set; }
        public decimal Quantity { get; set; }
        public short SvcPmType { get; set; }
        public short SvcMeterType { get; set; }
        public string Contnbr { get; set; }
        public decimal Lnseqnbr { get; set; }
        public int DexRowId { get; set; }
    }
}
