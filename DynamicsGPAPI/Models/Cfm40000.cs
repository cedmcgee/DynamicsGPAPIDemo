using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Cfm40000
    {
        public string Vendorid { get; set; }
        public string Ponumber { get; set; }
        public short Postatus { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime Duedate { get; set; }
        public decimal Amount { get; set; }
        public int DexRowId { get; set; }
    }
}
