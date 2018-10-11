using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Fa41100
    {
        public int Locationindx { get; set; }
        public string Locatnid { get; set; }
        public string Statedescr { get; set; }
        public string Countydescr { get; set; }
        public string Citydescr { get; set; }
        public string Stateabbrev { get; set; }
        public string Statecd { get; set; }
        public string Countycode { get; set; }
        public string Citycode { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; }
        public int DexRowId { get; set; }
    }
}
