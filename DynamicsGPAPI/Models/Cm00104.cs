using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Cm00104
    {
        public string EftformatId { get; set; }
        public short EftlineType { get; set; }
        public decimal Sqncline { get; set; }
        public short EftfieldNumber { get; set; }
        public string Eftxmltag { get; set; }
        public string Dscriptn { get; set; }
        public short EftmapsTo { get; set; }
        public string EftsourceTable { get; set; }
        public string FieldName { get; set; }
        public string EftdataValue { get; set; }
        public short Lofsgmnt { get; set; }
        public short EfttagHierarchy { get; set; }
        public short Eftoccurrence { get; set; }
        public short EftcalculationType { get; set; }
        public short Eftdatatype { get; set; }
        public short Eftjustification { get; set; }
        public string EftpadCharacter { get; set; }
        public short EftdecimalPlaces { get; set; }
        public byte EftremoveDecimalPlace { get; set; }
        public short Datefmt { get; set; }
        public byte EftuseTextQualifier { get; set; }
        public int DexRowId { get; set; }
    }
}
