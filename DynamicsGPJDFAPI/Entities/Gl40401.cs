using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Gl40401
    {
        public int ReconciliationNumber { get; set; }
        public DateTime ReconciliationDate { get; set; }
        public short Module1 { get; set; }
        public string FileName { get; set; }
        public decimal SubledgerBegBalance { get; set; }
        public decimal SubledgerEndingBalance { get; set; }
        public decimal GlBeginningBalance { get; set; }
        public decimal GlEndingBalance { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime Todate { get; set; }
        public string Chekbkid { get; set; }
        public short Status { get; set; }
        public int DexRowId { get; set; }
    }
}
