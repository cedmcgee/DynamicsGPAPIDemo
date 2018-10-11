using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sop50400
    {
        public string Userid { get; set; }
        public string Itemnmbr { get; set; }
        public string Uofm { get; set; }
        public string Prcshid { get; set; }
        public string Epitmtyp { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public decimal Qtyfrom { get; set; }
        public decimal Qtyto { get; set; }
        public decimal Psitmval { get; set; }
        public decimal Equomqty { get; set; }
        public string Baseuofm { get; set; }
        public short Promolvl { get; set; }
        public short Promotyp { get; set; }
        public string Prcgrpid { get; set; }
        public string Prodtcod { get; set; }
        public byte Active { get; set; }
        public int DexRowId { get; set; }
    }
}
