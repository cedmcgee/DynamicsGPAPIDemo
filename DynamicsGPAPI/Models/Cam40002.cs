using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Cam40002
    {
        public short CamaccountType { get; set; }
        public short CamSeries { get; set; }
        public string Sgmntid { get; set; }
        public int CamControlAccountIndex { get; set; }
        public int CamAccrualAccountIndex { get; set; }
        public string CamControlAcctDescr { get; set; }
        public string CamAccrualAcctDescr { get; set; }
        public int DexRowId { get; set; }
    }
}
