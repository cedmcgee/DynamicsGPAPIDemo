using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00850
    {
        public string EcoNumber { get; set; }
        public string Dscriptn { get; set; }
        public DateTime Date1 { get; set; }
        public decimal Noteindx { get; set; }
        public string Itemnmbr { get; set; }
        public string FromSerialNumber { get; set; }
        public string ToSerialNumber { get; set; }
        public byte Mandatory { get; set; }
        public string Srvtype { get; set; }
        public string Techid { get; set; }
        public int DexRowId { get; set; }
    }
}
