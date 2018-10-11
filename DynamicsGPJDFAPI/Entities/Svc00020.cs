using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00020
    {
        public string UserId { get; set; }
        public short PeriodId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PeriodName { get; set; }
        public short FiscalYear { get; set; }
        public int DexRowId { get; set; }
    }
}
