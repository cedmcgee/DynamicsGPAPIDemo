using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Cam10210
    {
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public short Cmpanyid { get; set; }
        public string Sgmntid { get; set; }
        public int CamControlAccountIndex { get; set; }
        public string CamcontrolAccount1 { get; set; }
        public string CamcontrolAccount2 { get; set; }
        public string CamcontrolAccount3 { get; set; }
        public string CamcontrolAccount4 { get; set; }
        public string CamcontrolAccount5 { get; set; }
        public string CamControlAcctDescr { get; set; }
        public decimal CamAmountTotal { get; set; }
        public int DexRowId { get; set; }
    }
}
