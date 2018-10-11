using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc06020
    {
        public string Wotype { get; set; }
        public string Dscriptn { get; set; }
        public string Wostat { get; set; }
        public string Routeid { get; set; }
        public int Wipinv { get; set; }
        public int Wiplabor { get; set; }
        public byte SvcDoExpense { get; set; }
        public int SvcExpenseIndex { get; set; }
        public int DexRowId { get; set; }
    }
}
