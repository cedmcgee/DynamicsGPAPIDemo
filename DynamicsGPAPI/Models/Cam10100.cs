using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Cam10100
    {
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public int CamControlAccountIndex { get; set; }
        public string CamAccountNumString { get; set; }
        public string CamControlAcctDescr { get; set; }
        public string Vendorid { get; set; }
        public int Actindx { get; set; }
        public string Actnumst { get; set; }
        public string Actdescr { get; set; }
        public string Vchrnmbr { get; set; }
        public string Aptvchnm { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal CamAmountTotal { get; set; }
        public int DexRowId { get; set; }
    }
}
