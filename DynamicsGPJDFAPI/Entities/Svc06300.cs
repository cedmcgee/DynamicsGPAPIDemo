using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc06300
    {
        public string Stationid { get; set; }
        public decimal Sequence1 { get; set; }
        public string QueueStatus { get; set; }
        public short Worectype { get; set; }
        public string Workordnum { get; set; }
        public decimal RouteSequence { get; set; }
        public decimal SvcDepotPriority { get; set; }
        public short Status { get; set; }
        public string Techid { get; set; }
        public decimal Ettr { get; set; }
        public DateTime Etadte { get; set; }
        public DateTime Etatme { get; set; }
        public DateTime Ecompdt { get; set; }
        public DateTime EcompTime { get; set; }
        public DateTime Actstrtdte { get; set; }
        public DateTime Actstrttme { get; set; }
        public string Lststaid { get; set; }
        public decimal LastSequence { get; set; }
        public string Nxtstatid { get; set; }
        public decimal Nxtseq { get; set; }
        public int DexRowId { get; set; }
    }
}
