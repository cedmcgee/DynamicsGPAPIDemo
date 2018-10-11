using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Upr41500
    {
        public string Shftcode { get; set; }
        public string Dscriptn { get; set; }
        public short Shfttype { get; set; }
        public decimal Shftamt { get; set; }
        public decimal Shftpct { get; set; }
        public byte Inactive { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
