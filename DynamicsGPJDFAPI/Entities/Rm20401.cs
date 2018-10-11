using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Rm20401
    {
        public string ScheduleNumber { get; set; }
        public string Docnumbr { get; set; }
        public short SchedulePaymentNumber { get; set; }
        public string Custnmbr { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal InterestAmount { get; set; }
        public decimal PrincipalAmount { get; set; }
        public decimal PrincipalBalance { get; set; }
        public DateTime Duedate { get; set; }
        public DateTime Docdate { get; set; }
        public short Status { get; set; }
        public byte Marked { get; set; }
        public string Mkdbyusr { get; set; }
        public int DexRowId { get; set; }
    }
}
