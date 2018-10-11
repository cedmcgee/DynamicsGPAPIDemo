using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc06105
    {
        public short Worectype { get; set; }
        public string Workordnum { get; set; }
        public short Status { get; set; }
        public decimal Sequence1 { get; set; }
        public string Dscriptn { get; set; }
        public string Depstatgrp { get; set; }
        public string Stationid { get; set; }
        public string Techid { get; set; }
        public decimal Ettr { get; set; }
        public string Routeproc { get; set; }
        public string Servicebom { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Strttime { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Endtime { get; set; }
        public DateTime Etadte { get; set; }
        public DateTime Etatme { get; set; }
        public DateTime Ecompdt { get; set; }
        public DateTime EcompTime { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
