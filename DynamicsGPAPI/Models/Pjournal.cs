using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pjournal
    {
        public string Userid { get; set; }
        public string Bchsourc { get; set; }
        public string Bachnumb { get; set; }
        public int Jrnentry { get; set; }
        public decimal Sqncline { get; set; }
        public int Actindx { get; set; }
        public int Offindx { get; set; }
        public byte[] Gllinmsg { get; set; }
        public byte[] Gllinms2 { get; set; }
        public DateTime Trxdate { get; set; }
        public short Accttype { get; set; }
        public string Dscriptn { get; set; }
        public string Curncyid { get; set; }
        public short Currnidx { get; set; }
        public short Funcridx { get; set; }
        public short Report { get; set; }
        public string Interid { get; set; }
        public string Actnumst { get; set; }
        public string Actdescr { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Orcrdamt { get; set; }
        public decimal Ordbtamt { get; set; }
        public string Orctrnum { get; set; }
        public string Ordocnum { get; set; }
        public string Ormstrid { get; set; }
        public string Ormstrnm { get; set; }
        public short Ortrxtyp { get; set; }
        public short Mctrxstt { get; set; }
        public decimal Xchgrate { get; set; }
        public decimal Denxrate { get; set; }
        public int DexRowId { get; set; }
    }
}
