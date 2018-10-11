using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Aag00315
    {
        public string Userid { get; set; }
        public short Year1 { get; set; }
        public string AaYearFld { get; set; }
        public short FromPeriod { get; set; }
        public short ToPeriod { get; set; }
        public string AaPerFld { get; set; }
        public string AaPerStr { get; set; }
        public string AaEmptyCodeStr { get; set; }
        public byte AaTimeSpreadUsed { get; set; }
        public byte AaCodeSpreadUsed { get; set; }
        public short AaCodeSpreadCol { get; set; }
        public string Thssprtr { get; set; }
        public string Decsprtr { get; set; }
        public string AaNegSignLeft { get; set; }
        public string AaNegSignRight { get; set; }
        public short AaTruncateTo { get; set; }
        public byte AaClearEmptyCells { get; set; }
        public int DexRowId { get; set; }
        public string AaSqlcreate { get; set; }
        public string AaSqlinsert { get; set; }
        public string AaSqlselect { get; set; }
        public string AaSqlfrom { get; set; }
        public string AaSqlwhere { get; set; }
        public string AaSqlgroupBy { get; set; }
        public string AaSqlcols { get; set; }
    }
}
