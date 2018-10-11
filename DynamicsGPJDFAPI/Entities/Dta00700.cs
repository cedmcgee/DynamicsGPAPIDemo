using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Dta00700
    {
        public short Rptgrind { get; set; }
        public decimal Rtgrsbin { get; set; }
        public short Rtpachin { get; set; }
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
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public string Startgrp { get; set; }
        public string Endgroup { get; set; }
        public string Strtcode { get; set; }
        public string Endcode { get; set; }
        public byte Prntdtld { get; set; }
        public byte Unpsttrx { get; set; }
        public byte Open1 { get; set; }
        public byte History { get; set; }
        public DateTime Sttpstdt { get; set; }
        public DateTime Endpstdt { get; set; }
        public int DexRowId { get; set; }
    }
}
