using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Gl10001
    {
        public string Bachnumb { get; set; }
        public int Jrnentry { get; set; }
        public decimal Sqncline { get; set; }
        public int Actindx { get; set; }
        public decimal Xchgrate { get; set; }
        public string Dscriptn { get; set; }
        public byte[] Gllinmsg { get; set; }
        public byte[] Gllinms2 { get; set; }
        public short Currnidx { get; set; }
        public byte[] Gllinval { get; set; }
        public short Accttype { get; set; }
        public short Fxdorvar { get; set; }
        public short Balfrclc { get; set; }
        public short Pstngtyp { get; set; }
        public short Decplacs { get; set; }
        public string Orctrnum { get; set; }
        public string Ordocnum { get; set; }
        public string Ormstrid { get; set; }
        public string Ormstrnm { get; set; }
        public short Ortrxtyp { get; set; }
        public int OrigSeqNum { get; set; }
        public string Ortrxdesc { get; set; }
        public short DtaGlStatus { get; set; }
        public string Interid { get; set; }
        public string Ratetpid { get; set; }
        public string Exgtblid { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Ordbtamt { get; set; }
        public decimal Orcrdamt { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public short Lnestat { get; set; }
        public string CorrespondingUnit { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
