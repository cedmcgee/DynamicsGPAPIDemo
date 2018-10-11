using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Cm00103
    {
        public string EftformatId { get; set; }
        public string Dscriptn { get; set; }
        public short EftformatType { get; set; }
        public short EftFileType { get; set; }
        public short EfttransferMethod { get; set; }
        public byte EftAutoSettlement { get; set; }
        public byte EftaddPadBlocks { get; set; }
        public string EftpadCharacter { get; set; }
        public short EftpadLength { get; set; }
        public short EftmaximumLineLength { get; set; }
        public short NumberOfLines { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public decimal Noteindx { get; set; }
        public short Series { get; set; }
        public byte MultipleAddendas { get; set; }
        public byte EftdelimitFields { get; set; }
        public short EftdelimiterField { get; set; }
        public string EftdelimiterFieldOther { get; set; }
        public short EfttextQualifier { get; set; }
        public int DexRowId { get; set; }
    }
}
