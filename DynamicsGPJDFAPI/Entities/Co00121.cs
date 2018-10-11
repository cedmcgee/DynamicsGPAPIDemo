using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Co00121
    {
        public string FieldsListGuid { get; set; }
        public int Seqnumbr { get; set; }
        public byte DefaultField { get; set; }
        public short TableDictId { get; set; }
        public short TableSeries { get; set; }
        public string TableTechnicalName { get; set; }
        public string TablePhysicalName { get; set; }
        public string TableDisplayName { get; set; }
        public string FieldPhysicalName { get; set; }
        public string FieldDisplayName { get; set; }
        public short FieldSource { get; set; }
        public short FieldDataType { get; set; }
        public short DecimalDigits { get; set; }
        public byte RelativeDecimalPosition { get; set; }
        public byte ShowCurrencySymbol { get; set; }
        public byte ShowPercentSign { get; set; }
        public string Crncysym { get; set; }
        public short Decplcur { get; set; }
        public byte Hidden { get; set; }
        public int DexRowId { get; set; }
    }
}
