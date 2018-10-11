using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Mc40000
    {
        public string Funlcurr { get; set; }
        public short Funcridx { get; set; }
        public string Rptgcurr { get; set; }
        public short Rptcridx { get; set; }
        public decimal Rptxrate { get; set; }
        public short Rprtclmd { get; set; }
        public byte Alownwrt { get; set; }
        public string Anwrtpwd { get; set; }
        public byte Alwmodrt { get; set; }
        public string Modrtpwd { get; set; }
        public byte Alovexrt { get; set; }
        public string Ovxrtpwd { get; set; }
        public byte Aovrtvar { get; set; }
        public string Ovrtvpwd { get; set; }
        public byte Aovrptrt { get; set; }
        public string Ovrprpwd { get; set; }
        public short Avgexrat { get; set; }
        public string Deffintp { get; set; }
        public string Defslstp { get; set; }
        public string Defpurtp { get; set; }
        public byte Mnsumhst { get; set; }
        public DateTime Lstreval { get; set; }
        public DateTime Lstprval { get; set; }
        public DateTime Lstsrval { get; set; }
        public DateTime Lsttrxrv { get; set; }
        public DateTime Lstsumrv { get; set; }
        public short Avgclmd { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
