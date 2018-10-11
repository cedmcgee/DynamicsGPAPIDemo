using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pm10900
    {
        public string Userid { get; set; }
        public DateTime Time1 { get; set; }
        public string Vendorid { get; set; }
        public short Doctype { get; set; }
        public string Vchrnmbr { get; set; }
        public byte[] Pmvdmsgs { get; set; }
        public DateTime Docdate { get; set; }
        public string Docnumbr { get; set; }
        public decimal Docamnt { get; set; }
        public decimal Ordocamt { get; set; }
        public decimal Curtrxam { get; set; }
        public decimal Orctrxam { get; set; }
        public decimal Distknam { get; set; }
        public decimal Ordistkn { get; set; }
        public decimal Discamnt { get; set; }
        public DateTime Discdate { get; set; }
        public string Trxsorce { get; set; }
        public decimal Ten99amnt { get; set; }
        public decimal Or1099am { get; set; }
        public decimal Wrofamnt { get; set; }
        public decimal Orwrofam { get; set; }
        public decimal Disamtav { get; set; }
        public decimal Odisamtav { get; set; }
        public decimal Prchamnt { get; set; }
        public decimal Opuramt { get; set; }
        public decimal Trdisamt { get; set; }
        public decimal Ortdisam { get; set; }
        public decimal Mscchamt { get; set; }
        public decimal Ormiscamt { get; set; }
        public decimal Frtamnt { get; set; }
        public decimal Orfrtamt { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Ortaxamt { get; set; }
        public decimal Ttlpymts { get; set; }
        public decimal Ototpay { get; set; }
        public short Cntrltyp { get; set; }
        public byte Changed { get; set; }
        public short Pstgstus { get; set; }
        public string Chekbkid { get; set; }
        public DateTime Pstgdate { get; set; }
        public string Curncyid { get; set; }
        public string Deydescr { get; set; }
        public DateTime Voiddate { get; set; }
        public int DexRowId { get; set; }
    }
}
