using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00310
    {
        public int Equipid { get; set; }
        public int Lnitmseq { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public string Userid { get; set; }
        public string FromCustomerNumber { get; set; }
        public string ToCustomerNumber { get; set; }
        public string FromConfigReference { get; set; }
        public string ToConfigReference { get; set; }
        public short FromConfgLevel { get; set; }
        public short ToConfigLevel { get; set; }
        public short FromConfigSequence { get; set; }
        public short ToConfigSequence { get; set; }
        public string FromSerialNumber { get; set; }
        public string ToSerialNumber { get; set; }
        public string FromItemNumber { get; set; }
        public string ToItemNumber { get; set; }
        public string Dscriptn { get; set; }
        public int DexRowId { get; set; }
    }
}
