using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag2000e
    {
        public int AaSubLedgerHdrId { get; set; }
        public int AaSubLedgerDistId { get; set; }
        public int AaSubLedgerAssignId { get; set; }
        public int AaDisplayDistId { get; set; }
        public byte Aadocval { get; set; }
        public short AaErrorNum { get; set; }
        public int AaAcctClassId { get; set; }
        public string AaTrxDim { get; set; }
        public string AaTrxDimCode { get; set; }
        public string AaRelatedTrxDim { get; set; }
        public string AaRelatedTrxDimCode { get; set; }
        public string Errdescr { get; set; }
        public string AaAccountClass { get; set; }
        public int DexRowId { get; set; }
    }
}
