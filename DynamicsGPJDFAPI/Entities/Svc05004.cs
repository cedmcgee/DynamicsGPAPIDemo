using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc05004
    {
        public string Vendorid { get; set; }
        public string Itemnmbr { get; set; }
        public string RtvType { get; set; }
        public string DollarOrPercentReimbu1 { get; set; }
        public string DollarOrPercentReimbu2 { get; set; }
        public string DollarOrPercentReimbu3 { get; set; }
        public string DollarOrPercentReimbu4 { get; set; }
        public decimal ReimbursementAmount1 { get; set; }
        public decimal ReimbursementAmount2 { get; set; }
        public decimal ReimbursementAmount3 { get; set; }
        public decimal ReimbursementAmount4 { get; set; }
        public decimal ReimbursementNte1 { get; set; }
        public decimal ReimbursementNte2 { get; set; }
        public decimal ReimbursementNte3 { get; set; }
        public decimal ReimbursementNte4 { get; set; }
        public int DexRowId { get; set; }
    }
}
