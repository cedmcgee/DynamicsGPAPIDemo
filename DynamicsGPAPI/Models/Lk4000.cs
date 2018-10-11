using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Lk4000
    {
        public string Finrptnm { get; set; }
        public string Stacnmst { get; set; }
        public string EndAccountNumberString { get; set; }
        public short Iffilxst { get; set; }
        public byte Askechtm { get; set; }
        public short LkStartTokenDate { get; set; }
        public short LkendTokenDate { get; set; }
        public short Prrptfor { get; set; }
        public string Prvyrcmb { get; set; }
        public byte Prtoscrn { get; set; }
        public byte Prtoprtr { get; set; }
        public short Expttype { get; set; }
        public byte Prntofil { get; set; }
        public string Filexpnm { get; set; }
        public short Rptgrind { get; set; }
        public decimal Rtgrsbin { get; set; }
        public short Rtpachin { get; set; }
        public short Reportid { get; set; }
        public DateTime Strtngdt { get; set; }
        public DateTime Endingdt { get; set; }
        public string Sttacnum1 { get; set; }
        public string Sttacnum2 { get; set; }
        public string Sttacnum3 { get; set; }
        public string Sttacnum4 { get; set; }
        public string Sttacnum5 { get; set; }
        public string Eaccnbr1 { get; set; }
        public string Eaccnbr2 { get; set; }
        public string Eaccnbr3 { get; set; }
        public string Eaccnbr4 { get; set; }
        public string Eaccnbr5 { get; set; }
        public int Strtjrnl { get; set; }
        public int Endjrnal { get; set; }
        public string Ssrcedoc { get; set; }
        public string Endsrcdc { get; set; }
        public string Strxsrc { get; set; }
        public string LkStartGroup { get; set; }
        public string LkEndGroup { get; set; }
        public string Entrxsrc { get; set; }
        public int StartLkLinkNo { get; set; }
        public int EndLkLinkNo { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public string Sttusrid { get; set; }
        public string Endusrid { get; set; }
        public short Sortby { get; set; }
        public decimal LkLinkBalance { get; set; }
        public byte MulticurrencyInformation { get; set; }
        public int DexRowId { get; set; }
    }
}
