using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00302
    {
        public int Equipid { get; set; }
        public string Serlnmbr { get; set; }
        public string Itemnmbr { get; set; }
        public string Refrence { get; set; }
        public int Oldequipid { get; set; }
        public string Oldsernbr { get; set; }
        public string Olditemnbr { get; set; }
        public string Oldrefid { get; set; }
        public DateTime Lstdtedt { get; set; }
        public string Userid { get; set; }
        public int DexRowId { get; set; }
    }
}
