using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Upr42100
    {
        public string PaySchedule { get; set; }
        public string Dscriptn { get; set; }
        public short Payperod { get; set; }
        public short PastPayPeriods { get; set; }
        public short CurrentPayPeriods { get; set; }
        public int DexRowId { get; set; }
    }
}
