using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Mc40600
    {
        public string Curncyid { get; set; }
        public string CurrentExchangeTableId { get; set; }
        public string HistoricalExchgTableId { get; set; }
        public string AverageExchangeTableId { get; set; }
        public string BudgetExchangeTableId { get; set; }
        public int DexRowId { get; set; }
    }
}
