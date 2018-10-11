using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag00400
    {
        public int AaTrxDimId { get; set; }
        public string AaTrxDim { get; set; }
        public short AaDataType { get; set; }
        public string AaTrxDimDescr { get; set; }
        public string AaTrxDimDescr2 { get; set; }
        public int AaOrder { get; set; }
        public short Decplqty { get; set; }
        public string Uomschdl { get; set; }
        public byte AaAddrTrue { get; set; }
        public byte AaAddCodesOnFly { get; set; }
        public byte AaDontAskForNewCodes { get; set; }
        public decimal Noteindx { get; set; }
        public byte Inactive { get; set; }
        public byte AaIncYec { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
