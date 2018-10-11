using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sy02500
    {
        public short Endtype { get; set; }
        public short Series { get; set; }
        public short Module1 { get; set; }
        public short Index1 { get; set; }
        public string Rutiname { get; set; }
        public DateTime Datedone { get; set; }
        public string Userid { get; set; }
        public short Palcmdtp { get; set; }
        public string Paletcmd { get; set; }
        public string Aplicfil { get; set; }
        public short Dictid { get; set; }
        public DateTime Time1 { get; set; }
        public int DexRowId { get; set; }
    }
}
