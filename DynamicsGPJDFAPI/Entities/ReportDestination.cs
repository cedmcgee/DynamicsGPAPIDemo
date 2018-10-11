﻿using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class ReportDestination
    {
        public byte Prntofil { get; set; }
        public short Prodid { get; set; }
        public short Rptgrind { get; set; }
        public decimal Rtgrsbin { get; set; }
        public short Rtpachin { get; set; }
        public short Rtcfgwin { get; set; }
        public byte Askechtm { get; set; }
        public byte Prtoprtr { get; set; }
        public byte Prtoscrn { get; set; }
        public short Expttype { get; set; }
        public string Filexpnm { get; set; }
        public short Iffilxst { get; set; }
        public int DexRowId { get; set; }
    }
}
