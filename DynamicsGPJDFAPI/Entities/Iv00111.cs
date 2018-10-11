using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Iv00111
    {
        public string Locncode { get; set; }
        public short Orderpolicy { get; set; }
        public decimal Fxdordrqty { get; set; }
        public short Nmbrofdys { get; set; }
        public decimal Ordrpntqty { get; set; }
        public short Replenishmentmethod { get; set; }
        public decimal Prchsngldtm { get; set; }
        public decimal Mnfctrngfxdldtm { get; set; }
        public decimal Mnfctrngvrblldtm { get; set; }
        public decimal Stagingldtme { get; set; }
        public short Plnnngtmfncdys { get; set; }
        public short Dmndtmfncprds { get; set; }
        public string Buyerid { get; set; }
        public string Plannerid { get; set; }
        public short Frcstcnsmptnprd { get; set; }
        public byte Inclddinplnnng { get; set; }
        public byte Calculateatp { get; set; }
        public byte Autochkatp { get; set; }
        public byte Plnfnlpab { get; set; }
        public short MoveOutFence { get; set; }
        public int DexRowId { get; set; }
    }
}
