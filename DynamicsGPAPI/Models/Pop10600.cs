﻿using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pop10600
    {
        public string Popivcno { get; set; }
        public int Ivclinno { get; set; }
        public string Poprctnm { get; set; }
        public int Rcptlnnm { get; set; }
        public int Lclinenumber { get; set; }
        public short Status { get; set; }
        public decimal Qtyinvcd { get; set; }
        public decimal Qtyinvreserve { get; set; }
        public decimal Oruntcst { get; set; }
        public decimal Rcptcost { get; set; }
        public decimal Orcptcost { get; set; }
        public decimal Acpurtot { get; set; }
        public decimal Uppvtotl { get; set; }
        public int Purpvidx { get; set; }
        public decimal Pchrptct { get; set; }
        public decimal Sprcptct { get; set; }
        public string Curncyid { get; set; }
        public short Currnidx { get; set; }
        public decimal Xchgrate { get; set; }
        public short Ratecalc { get; set; }
        public decimal Denxrate { get; set; }
        public byte RevalueInventory { get; set; }
        public decimal Ppvtotal { get; set; }
        public int Invindx { get; set; }
        public decimal Bcktxamt { get; set; }
        public decimal Obtaxamt { get; set; }
        public decimal Prcntofttl { get; set; }
        public int DexRowId { get; set; }
    }
}
