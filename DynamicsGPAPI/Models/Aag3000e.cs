using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag3000e
    {
        public int AaGlworkHdrId { get; set; }
        public int AaGlworkDistId { get; set; }
        public int AaGlworkAssignId { get; set; }
        public int AaDisplayDistId { get; set; }
        public byte Aadocval { get; set; }
        public short AaErrorNum { get; set; }
        public string AaTrxDim { get; set; }
        public int AaAcctClassId { get; set; }
        public string AaTrxDimCode { get; set; }
        public string AaRelatedTrxDim { get; set; }
        public string AaRelatedTrxDimCode { get; set; }
        public string Errdescr { get; set; }
        public string AaAccountClass { get; set; }
        public int DexRowId { get; set; }
    }
}
