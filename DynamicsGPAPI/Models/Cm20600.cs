using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Cm20600
    {
        public decimal XfrRecordNumber { get; set; }
        public string Cmxfrnum { get; set; }
        public decimal Cmfrmrecnum { get; set; }
        public decimal Cmtorecnum { get; set; }
        public short Cmfrmstatus { get; set; }
        public short Cmtostatus { get; set; }
        public string Cmfrmchkbkid { get; set; }
        public string Cmchkbkid { get; set; }
        public DateTime Cmxftdate { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
