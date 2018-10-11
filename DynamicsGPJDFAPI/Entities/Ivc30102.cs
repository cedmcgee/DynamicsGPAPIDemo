﻿using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Ivc30102
    {
        public short Doctype { get; set; }
        public string Invcnmbr { get; set; }
        public int Lnitmseq { get; set; }
        public int Cmpntseq { get; set; }
        public short Noninven { get; set; }
        public string Itemnmbr { get; set; }
        public short Decplcur { get; set; }
        public short Decplqty { get; set; }
        public string Itmtshid { get; set; }
        public short Ivitmtxb { get; set; }
        public decimal Quantity { get; set; }
        public decimal Qtyinsvc { get; set; }
        public decimal Qtyinuse { get; set; }
        public decimal Qtydmged { get; set; }
        public decimal Qtyrtrnd { get; set; }
        public decimal Qtyonhnd { get; set; }
        public decimal Extqtysel { get; set; }
        public string Uofm { get; set; }
        public decimal Qtybsuom { get; set; }
        public decimal Unitcost { get; set; }
        public decimal Extdcost { get; set; }
        public decimal Atyalloc { get; set; }
        public string Locncode { get; set; }
        public short Mrkdntyp { get; set; }
        public decimal Mrkdnamt { get; set; }
        public short Mrkdnpct { get; set; }
        public string Prclevel { get; set; }
        public decimal Xtndprce { get; set; }
        public decimal Unitprce { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Bktslsam { get; set; }
        public decimal Txbtxamt { get; set; }
        public string Slprsnid { get; set; }
        public string Salsterr { get; set; }
        public string Dscriptn { get; set; }
        public string Itemdesc { get; set; }
        public DateTime Exptship { get; set; }
        public DateTime Actlship { get; set; }
        public DateTime ReqShipDate { get; set; }
        public decimal Comdlram { get; set; }
        public byte Cmpsernm { get; set; }
        public string Commntid { get; set; }
        public short Brkfld1 { get; set; }
        public short Brkfld2 { get; set; }
        public short Brkfld3 { get; set; }
        public string Trxsorce { get; set; }
        public string Prstadcd { get; set; }
        public string Shipmthd { get; set; }
        public byte Islineintra { get; set; }
        public int DexRowId { get; set; }
    }
}
