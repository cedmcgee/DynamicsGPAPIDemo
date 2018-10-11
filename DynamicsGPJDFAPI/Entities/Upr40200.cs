using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Upr40200
    {
        public short Setupkey { get; set; }
        public byte Autovrtm { get; set; }
        public int Reghrsrq { get; set; }
        public DateTime Lsfutadt { get; set; }
        public DateTime Lssutadt { get; set; }
        public DateTime Lswcmpdt { get; set; }
        public string Usrdfpr1 { get; set; }
        public string Usrdrpr2 { get; set; }
        public string Compchid { get; set; }
        public string Mlchbkid { get; set; }
        public int Uprnpnum { get; set; }
        public int Uprnanum { get; set; }
        public int Nxctrnum { get; set; }
        public int Nxmtrnum { get; set; }
        public byte Kpychkhs { get; set; }
        public byte Kpptrhst { get; set; }
        public byte Kpygldst { get; set; }
        public byte Edfinfld { get; set; }
        public byte Dspyrtrx { get; set; }
        public byte CalcTipAlloc { get; set; }
        public decimal TipAllocRate { get; set; }
        public byte Trkdywkd { get; set; }
        public byte Trkwkwkd { get; set; }
        public short Payrtdec { get; set; }
        public short Dedtndec { get; set; }
        public short Bnftdcml { get; set; }
        public short Chkfrmat { get; set; }
        public string Scktmavlpwd { get; set; }
        public string Vctavlpwd { get; set; }
        public byte BenefitYtdAmts { get; set; }
        public byte DeductionYtdAmts { get; set; }
        public byte LocalTaxesYtdAmts { get; set; }
        public byte PayCodeYtdAmts { get; set; }
        public byte StateTaxesYtdAmts { get; set; }
        public short Pyftrdec { get; set; }
        public byte EnableFiscalTracking { get; set; }
        public short CheckPrintDefault { get; set; }
        public byte Viewmultdir { get; set; }
        public byte Incinemp { get; set; }
        public int DexRowId { get; set; }
    }
}
